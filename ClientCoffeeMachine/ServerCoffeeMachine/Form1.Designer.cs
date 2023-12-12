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
            this.waterBtn = new System.Windows.Forms.Button();
            this.milkBtn = new System.Windows.Forms.Button();
            this.coffeeBtn = new System.Windows.Forms.Button();
            this.sugarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartServer
            // 
            this.btnStartServer.BackgroundImage = global::ServerCoffeeMachine.Properties.Resources.on_button;
            this.btnStartServer.Location = new System.Drawing.Point(12, 12);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(68, 62);
            this.btnStartServer.TabIndex = 0;
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(279, 12);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(509, 413);
            this.txtReceived.TabIndex = 1;
            // 
            // waterBtn
            // 
            this.waterBtn.Location = new System.Drawing.Point(13, 130);
            this.waterBtn.Name = "waterBtn";
            this.waterBtn.Size = new System.Drawing.Size(122, 46);
            this.waterBtn.TabIndex = 2;
            this.waterBtn.Text = "Replenish water";
            this.waterBtn.UseVisualStyleBackColor = true;
            this.waterBtn.Click += new System.EventHandler(this.waterBtn_Click);
            // 
            // milkBtn
            // 
            this.milkBtn.Location = new System.Drawing.Point(13, 205);
            this.milkBtn.Name = "milkBtn";
            this.milkBtn.Size = new System.Drawing.Size(122, 48);
            this.milkBtn.TabIndex = 3;
            this.milkBtn.Text = "Replenish milk";
            this.milkBtn.UseVisualStyleBackColor = true;
            this.milkBtn.Click += new System.EventHandler(this.milkBtn_Click);
            // 
            // coffeeBtn
            // 
            this.coffeeBtn.Location = new System.Drawing.Point(13, 274);
            this.coffeeBtn.Name = "coffeeBtn";
            this.coffeeBtn.Size = new System.Drawing.Size(122, 48);
            this.coffeeBtn.TabIndex = 4;
            this.coffeeBtn.Text = "Replenish coffee";
            this.coffeeBtn.UseVisualStyleBackColor = true;
            this.coffeeBtn.Click += new System.EventHandler(this.coffeeBtn_Click);
            // 
            // sugarBtn
            // 
            this.sugarBtn.Location = new System.Drawing.Point(13, 342);
            this.sugarBtn.Name = "sugarBtn";
            this.sugarBtn.Size = new System.Drawing.Size(122, 48);
            this.sugarBtn.TabIndex = 5;
            this.sugarBtn.Text = "Replenish sugar";
            this.sugarBtn.UseVisualStyleBackColor = true;
            this.sugarBtn.Click += new System.EventHandler(this.sugarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sugarBtn);
            this.Controls.Add(this.coffeeBtn);
            this.Controls.Add(this.milkBtn);
            this.Controls.Add(this.waterBtn);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.btnStartServer);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.Button waterBtn;
        private System.Windows.Forms.Button milkBtn;
        private System.Windows.Forms.Button coffeeBtn;
        private System.Windows.Forms.Button sugarBtn;
    }
}

