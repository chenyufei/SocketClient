namespace SocketClient
{
    partial class FrmClient
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_CloseConnect = new System.Windows.Forms.Button();
            this.richTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Msg = new System.Windows.Forms.RichTextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(13, 13);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(148, 21);
            this.textBox_IP.TabIndex = 0;
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(202, 12);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(93, 21);
            this.textBox_Port.TabIndex = 1;
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(352, 10);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_Connect.TabIndex = 2;
            this.button_Connect.Text = "连接";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_CloseConnect
            // 
            this.button_CloseConnect.Location = new System.Drawing.Point(470, 11);
            this.button_CloseConnect.Name = "button_CloseConnect";
            this.button_CloseConnect.Size = new System.Drawing.Size(75, 23);
            this.button_CloseConnect.TabIndex = 3;
            this.button_CloseConnect.Text = "断开连接";
            this.button_CloseConnect.UseVisualStyleBackColor = true;
            this.button_CloseConnect.Click += new System.EventHandler(this.button_CloseConnect_Click);
            // 
            // richTextBox_Log
            // 
            this.richTextBox_Log.Location = new System.Drawing.Point(13, 165);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.Size = new System.Drawing.Size(763, 96);
            this.richTextBox_Log.TabIndex = 4;
            this.richTextBox_Log.Text = "";
            // 
            // richTextBox_Msg
            // 
            this.richTextBox_Msg.Location = new System.Drawing.Point(13, 49);
            this.richTextBox_Msg.Name = "richTextBox_Msg";
            this.richTextBox_Msg.Size = new System.Drawing.Size(763, 96);
            this.richTextBox_Msg.TabIndex = 5;
            this.richTextBox_Msg.Text = "";
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(614, 348);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 6;
            this.button_Send.Text = "发送消息";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.richTextBox_Msg);
            this.Controls.Add(this.richTextBox_Log);
            this.Controls.Add(this.button_CloseConnect);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.textBox_IP);
            this.Name = "FrmClient";
            this.Text = "客户端";
            this.Load += new System.EventHandler(this.FrmClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_CloseConnect;
        private System.Windows.Forms.RichTextBox richTextBox_Log;
        private System.Windows.Forms.RichTextBox richTextBox_Msg;
        private System.Windows.Forms.Button button_Send;
    }
}

