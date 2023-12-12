namespace ClientCoffeeMachine
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
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtMessageToSend = new System.Windows.Forms.TextBox();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teaRB = new System.Windows.Forms.RadioButton();
            this.americanoRB = new System.Windows.Forms.RadioButton();
            this.cappucinoRB = new System.Windows.Forms.RadioButton();
            this.espressoRB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sugarFreeRB = new System.Windows.Forms.RadioButton();
            this.semiSweetRB = new System.Windows.Forms.RadioButton();
            this.sweetRB = new System.Windows.Forms.RadioButton();
            this.orderBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(959, 25);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(118, 33);
            this.btnSendMessage.TabIndex = 0;
            this.btnSendMessage.Text = "button1";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtMessageToSend
            // 
            this.txtMessageToSend.Location = new System.Drawing.Point(33, 25);
            this.txtMessageToSend.Multiline = true;
            this.txtMessageToSend.Name = "txtMessageToSend";
            this.txtMessageToSend.Size = new System.Drawing.Size(392, 453);
            this.txtMessageToSend.TabIndex = 1;
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(461, 30);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(492, 448);
            this.txtReceived.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teaRB);
            this.groupBox1.Controls.Add(this.americanoRB);
            this.groupBox1.Controls.Add(this.cappucinoRB);
            this.groupBox1.Controls.Add(this.espressoRB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(165, 514);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 145);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beverage";
            // 
            // teaRB
            // 
            this.teaRB.AutoSize = true;
            this.teaRB.Location = new System.Drawing.Point(6, 114);
            this.teaRB.Name = "teaRB";
            this.teaRB.Size = new System.Drawing.Size(58, 24);
            this.teaRB.TabIndex = 3;
            this.teaRB.TabStop = true;
            this.teaRB.Text = "Tea";
            this.teaRB.UseVisualStyleBackColor = true;
            // 
            // americanoRB
            // 
            this.americanoRB.AutoSize = true;
            this.americanoRB.Location = new System.Drawing.Point(7, 89);
            this.americanoRB.Name = "americanoRB";
            this.americanoRB.Size = new System.Drawing.Size(110, 24);
            this.americanoRB.TabIndex = 2;
            this.americanoRB.TabStop = true;
            this.americanoRB.Text = "Americano";
            this.americanoRB.UseVisualStyleBackColor = true;
            // 
            // cappucinoRB
            // 
            this.cappucinoRB.AutoSize = true;
            this.cappucinoRB.Location = new System.Drawing.Point(7, 58);
            this.cappucinoRB.Name = "cappucinoRB";
            this.cappucinoRB.Size = new System.Drawing.Size(109, 24);
            this.cappucinoRB.TabIndex = 1;
            this.cappucinoRB.TabStop = true;
            this.cappucinoRB.Text = "Cappucino";
            this.cappucinoRB.UseVisualStyleBackColor = true;
            // 
            // espressoRB
            // 
            this.espressoRB.AutoSize = true;
            this.espressoRB.Location = new System.Drawing.Point(7, 27);
            this.espressoRB.Name = "espressoRB";
            this.espressoRB.Size = new System.Drawing.Size(101, 24);
            this.espressoRB.TabIndex = 0;
            this.espressoRB.TabStop = true;
            this.espressoRB.Text = "Espresso";
            this.espressoRB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sugarFreeRB);
            this.groupBox2.Controls.Add(this.semiSweetRB);
            this.groupBox2.Controls.Add(this.sweetRB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(580, 523);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 119);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sugar";
            // 
            // sugarFreeRB
            // 
            this.sugarFreeRB.AutoSize = true;
            this.sugarFreeRB.Location = new System.Drawing.Point(7, 89);
            this.sugarFreeRB.Name = "sugarFreeRB";
            this.sugarFreeRB.Size = new System.Drawing.Size(108, 24);
            this.sugarFreeRB.TabIndex = 2;
            this.sugarFreeRB.TabStop = true;
            this.sugarFreeRB.Text = "Sugar free";
            this.sugarFreeRB.UseVisualStyleBackColor = true;
            // 
            // semiSweetRB
            // 
            this.semiSweetRB.AutoSize = true;
            this.semiSweetRB.Location = new System.Drawing.Point(7, 58);
            this.semiSweetRB.Name = "semiSweetRB";
            this.semiSweetRB.Size = new System.Drawing.Size(119, 24);
            this.semiSweetRB.TabIndex = 1;
            this.semiSweetRB.TabStop = true;
            this.semiSweetRB.Text = "Semi Sweet";
            this.semiSweetRB.UseVisualStyleBackColor = true;
            // 
            // sweetRB
            // 
            this.sweetRB.AutoSize = true;
            this.sweetRB.Location = new System.Drawing.Point(7, 27);
            this.sweetRB.Name = "sweetRB";
            this.sweetRB.Size = new System.Drawing.Size(76, 24);
            this.sweetRB.TabIndex = 0;
            this.sweetRB.TabStop = true;
            this.sweetRB.Text = "Sweet";
            this.sweetRB.UseVisualStyleBackColor = true;
            // 
            // orderBtn
            // 
            this.orderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderBtn.Location = new System.Drawing.Point(937, 568);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(108, 43);
            this.orderBtn.TabIndex = 5;
            this.orderBtn.Text = "Order";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 740);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.txtMessageToSend);
            this.Controls.Add(this.btnSendMessage);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtMessageToSend;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton teaRB;
        private System.Windows.Forms.RadioButton americanoRB;
        private System.Windows.Forms.RadioButton cappucinoRB;
        private System.Windows.Forms.RadioButton espressoRB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton sugarFreeRB;
        private System.Windows.Forms.RadioButton semiSweetRB;
        private System.Windows.Forms.RadioButton sweetRB;
        private System.Windows.Forms.Button orderBtn;
    }
}

