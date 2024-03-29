﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketClient
{
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        //定义回调
        private delegate void SetTextCallBack(string strValue);

        //声明
        private SetTextCallBack setCallBack;

        //定义接收服务端发送消息的回调
        private delegate void ReceiveMsgCallBack(string strMsg);

        //声明
        private ReceiveMsgCallBack receiveCallBack;

        //创建连接的Socket
        Socket socketSend;
        //创建接收客户端发送消息的线程
        Thread threadReceive;

        private void button_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(this.textBox_IP.Text.Trim());
                socketSend.Connect(ip, Convert.ToInt32(this.textBox_Port.Text.Trim()));

                //实例化回调
                setCallBack = new SetTextCallBack(SetValue);
                receiveCallBack = new ReceiveMsgCallBack(SetValue);
                this.richTextBox_Log.Invoke(setCallBack, "连接成功");


                //开启一个新的线程不停的接收服务器发送消息的线程
                threadReceive = new Thread(new ThreadStart(Receive));

                //设置为后台线程
                threadReceive.IsBackground = true;
                threadReceive.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接服务端出错:" + ex.ToString());
            }
        }
        /// <summary>
        /// 接口服务器发送的消息
        /// </summary>
        private void Receive()

        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[2048];
                    //实际接收到的字节数
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    else
                    {
                        //判断发送的数据的类型
                        if (buffer[0] == 0)//表示发送的是文字消息
                        {
                            string str = Encoding.Default.GetString(buffer, 1, r - 1);
                            this.richTextBox_Log.Invoke(receiveCallBack, "接收远程服务器:" + socketSend.RemoteEndPoint + "发送的消息:" + str);
                        }
                        //表示发送的是文件
                        if (buffer[0] == 1)
                        {
                            SaveFileDialog sfd = new SaveFileDialog();
                            sfd.InitialDirectory = @"";
                            sfd.Title = "请选择要保存的文件";
                            sfd.Filter = "所有文件|*.*";
                            sfd.ShowDialog(this);

                            string strPath = sfd.FileName;
                            using (FileStream fsWrite = new FileStream(strPath, FileMode.OpenOrCreate, FileAccess.Write))
                            {
                                fsWrite.Write(buffer, 1, r - 1);
                            }
                            MessageBox.Show("保存文件成功");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("接收服务端发送的消息出错:" + ex.ToString());
            }
        }
        private void SetValue(string strValue)

        {
            this.richTextBox_Msg.AppendText(strValue + "\r \n");
        }
        private void button_CloseConnect_Click(object sender, EventArgs e)
        {
            //关闭socket
            socketSend.Close();

            //终止线程
            threadReceive.Abort();
        }
        private void button_Send_Click(object sender, EventArgs e)
        {
            try
            {
                string strMsg = this.richTextBox_Msg.Text.Trim();
                byte[] buffer = new byte[2048];
                buffer = Encoding.Default.GetBytes(strMsg);
                int receive = socketSend.Send(buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("发送消息出错:" + ex.Message);
            }
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
