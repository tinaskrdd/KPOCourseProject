namespace ServerCoffeeMachine
{
    partial class Form1
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
            this.btnStartServer = new System.Windows.Forms.Button();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.serverMessageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.historyMessageBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(111, 141);
            this.btnStartServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(84, 29);
            this.btnStartServer.TabIndex = 0;
            this.btnStartServer.Text = "button1";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(111, 80);
            this.txtReceived.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(285, 26);
            this.txtReceived.TabIndex = 1;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(107, 23);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(95, 20);
            this.stateLabel.TabIndex = 2;
            this.stateLabel.Text = "Server state";
            // 
            // serverMessageLabel
            // 
            this.serverMessageLabel.AutoSize = true;
            this.serverMessageLabel.Location = new System.Drawing.Point(111, 56);
            this.serverMessageLabel.Name = "serverMessageLabel";
            this.serverMessageLabel.Size = new System.Drawing.Size(0, 20);
            this.serverMessageLabel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "History";
            // 
            // historyMessageBox
            // 
            this.historyMessageBox.Location = new System.Drawing.Point(577, 56);
            this.historyMessageBox.Multiline = true;
            this.historyMessageBox.Name = "historyMessageBox";
            this.historyMessageBox.Size = new System.Drawing.Size(291, 342);
            this.historyMessageBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.historyMessageBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverMessageLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.btnStartServer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Server UI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label serverMessageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox historyMessageBox;
    }
}

