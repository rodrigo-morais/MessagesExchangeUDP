namespace MessageExchangeUPD
{
    partial class Messaging
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblConversation = new System.Windows.Forms.Label();
            this.txtConversation = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.grbConnection = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtRemotePort = new System.Windows.Forms.TextBox();
            this.lblRemotePort = new System.Windows.Forms.Label();
            this.txtRemoteIP = new System.Windows.Forms.TextBox();
            this.lblRemoteIP = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblMyPort = new System.Windows.Forms.Label();
            this.grbConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 109);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(77, 13);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "New message:";
            // 
            // txtMessage
            // 
            this.txtMessage.Enabled = false;
            this.txtMessage.Location = new System.Drawing.Point(95, 106);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(442, 20);
            this.txtMessage.TabIndex = 6;
            // 
            // lblConversation
            // 
            this.lblConversation.AutoSize = true;
            this.lblConversation.Location = new System.Drawing.Point(12, 155);
            this.lblConversation.Name = "lblConversation";
            this.lblConversation.Size = new System.Drawing.Size(72, 13);
            this.lblConversation.TabIndex = 2;
            this.lblConversation.Text = "Conversation:";
            // 
            // txtConversation
            // 
            this.txtConversation.Location = new System.Drawing.Point(15, 171);
            this.txtConversation.Multiline = true;
            this.txtConversation.Name = "txtConversation";
            this.txtConversation.ReadOnly = true;
            this.txtConversation.Size = new System.Drawing.Size(522, 205);
            this.txtConversation.TabIndex = 3;
            this.txtConversation.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(462, 132);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // grbConnection
            // 
            this.grbConnection.Controls.Add(this.btnDisconnect);
            this.grbConnection.Controls.Add(this.btnConnect);
            this.grbConnection.Controls.Add(this.txtRemotePort);
            this.grbConnection.Controls.Add(this.lblRemotePort);
            this.grbConnection.Controls.Add(this.txtRemoteIP);
            this.grbConnection.Controls.Add(this.lblRemoteIP);
            this.grbConnection.Controls.Add(this.txtPort);
            this.grbConnection.Controls.Add(this.lblMyPort);
            this.grbConnection.Location = new System.Drawing.Point(15, 10);
            this.grbConnection.Name = "grbConnection";
            this.grbConnection.Size = new System.Drawing.Size(522, 78);
            this.grbConnection.TabIndex = 5;
            this.grbConnection.TabStop = false;
            this.grbConnection.Text = "Connection";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(432, 49);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(351, 49);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtRemotePort
            // 
            this.txtRemotePort.Location = new System.Drawing.Point(425, 23);
            this.txtRemotePort.Name = "txtRemotePort";
            this.txtRemotePort.Size = new System.Drawing.Size(82, 20);
            this.txtRemotePort.TabIndex = 3;
            // 
            // lblRemotePort
            // 
            this.lblRemotePort.AutoSize = true;
            this.lblRemotePort.Location = new System.Drawing.Point(409, 26);
            this.lblRemotePort.Name = "lblRemotePort";
            this.lblRemotePort.Size = new System.Drawing.Size(10, 13);
            this.lblRemotePort.TabIndex = 4;
            this.lblRemotePort.Text = ":";
            // 
            // txtRemoteIP
            // 
            this.txtRemoteIP.Location = new System.Drawing.Point(241, 23);
            this.txtRemoteIP.Name = "txtRemoteIP";
            this.txtRemoteIP.Size = new System.Drawing.Size(162, 20);
            this.txtRemoteIP.TabIndex = 2;
            // 
            // lblRemoteIP
            // 
            this.lblRemoteIP.AutoSize = true;
            this.lblRemoteIP.Location = new System.Drawing.Point(175, 26);
            this.lblRemoteIP.Name = "lblRemoteIP";
            this.lblRemoteIP.Size = new System.Drawing.Size(60, 13);
            this.lblRemoteIP.TabIndex = 2;
            this.lblRemoteIP.Text = "Remote IP:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(58, 23);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(82, 20);
            this.txtPort.TabIndex = 1;
            // 
            // lblMyPort
            // 
            this.lblMyPort.AutoSize = true;
            this.lblMyPort.Location = new System.Drawing.Point(6, 26);
            this.lblMyPort.Name = "lblMyPort";
            this.lblMyPort.Size = new System.Drawing.Size(46, 13);
            this.lblMyPort.TabIndex = 0;
            this.lblMyPort.Text = "My Port:";
            // 
            // Messaging
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 388);
            this.Controls.Add(this.grbConnection);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtConversation);
            this.Controls.Add(this.lblConversation);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Messaging";
            this.Text = "Messages Exchange";
            this.grbConnection.ResumeLayout(false);
            this.grbConnection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblConversation;
        private System.Windows.Forms.TextBox txtConversation;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox grbConnection;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtRemotePort;
        private System.Windows.Forms.Label lblRemotePort;
        private System.Windows.Forms.TextBox txtRemoteIP;
        private System.Windows.Forms.Label lblRemoteIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblMyPort;
    }
}

