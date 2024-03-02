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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.americanoRB = new System.Windows.Forms.RadioButton();
            this.cappucinoRB = new System.Windows.Forms.RadioButton();
            this.espressoRB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sugarFreeRB = new System.Windows.Forms.RadioButton();
            this.semiSweetRB = new System.Windows.Forms.RadioButton();
            this.sweetRB = new System.Windows.Forms.RadioButton();
            this.orderBtn = new System.Windows.Forms.Button();
            this.CoffeeRem = new System.Windows.Forms.TextBox();
            this.WaterRem = new System.Windows.Forms.TextBox();
            this.MilkRem = new System.Windows.Forms.TextBox();
            this.SugarRem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.infoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.americanoRB);
            this.groupBox1.Controls.Add(this.cappucinoRB);
            this.groupBox1.Controls.Add(this.espressoRB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(57, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 188);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beverage";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // americanoRB
            // 
            this.americanoRB.AutoSize = true;
            this.americanoRB.Location = new System.Drawing.Point(6, 133);
            this.americanoRB.Name = "americanoRB";
            this.americanoRB.Size = new System.Drawing.Size(171, 36);
            this.americanoRB.TabIndex = 2;
            this.americanoRB.TabStop = true;
            this.americanoRB.Text = "Americano";
            this.americanoRB.UseVisualStyleBackColor = true;
            // 
            // cappucinoRB
            // 
            this.cappucinoRB.AutoSize = true;
            this.cappucinoRB.Location = new System.Drawing.Point(5, 91);
            this.cappucinoRB.Name = "cappucinoRB";
            this.cappucinoRB.Size = new System.Drawing.Size(172, 36);
            this.cappucinoRB.TabIndex = 1;
            this.cappucinoRB.TabStop = true;
            this.cappucinoRB.Text = "Cappucino";
            this.cappucinoRB.UseVisualStyleBackColor = true;
            // 
            // espressoRB
            // 
            this.espressoRB.AutoSize = true;
            this.espressoRB.Location = new System.Drawing.Point(6, 49);
            this.espressoRB.Name = "espressoRB";
            this.espressoRB.Size = new System.Drawing.Size(153, 36);
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(438, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 188);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sugar";
            // 
            // sugarFreeRB
            // 
            this.sugarFreeRB.AutoSize = true;
            this.sugarFreeRB.Location = new System.Drawing.Point(6, 133);
            this.sugarFreeRB.Name = "sugarFreeRB";
            this.sugarFreeRB.Size = new System.Drawing.Size(167, 36);
            this.sugarFreeRB.TabIndex = 2;
            this.sugarFreeRB.TabStop = true;
            this.sugarFreeRB.Text = "Sugar free";
            this.sugarFreeRB.UseVisualStyleBackColor = true;
            // 
            // semiSweetRB
            // 
            this.semiSweetRB.AutoSize = true;
            this.semiSweetRB.Location = new System.Drawing.Point(6, 83);
            this.semiSweetRB.Name = "semiSweetRB";
            this.semiSweetRB.Size = new System.Drawing.Size(186, 36);
            this.semiSweetRB.TabIndex = 1;
            this.semiSweetRB.TabStop = true;
            this.semiSweetRB.Text = "Semi Sweet";
            this.semiSweetRB.UseVisualStyleBackColor = true;
            // 
            // sweetRB
            // 
            this.sweetRB.AutoSize = true;
            this.sweetRB.Location = new System.Drawing.Point(6, 41);
            this.sweetRB.Name = "sweetRB";
            this.sweetRB.Size = new System.Drawing.Size(114, 36);
            this.sweetRB.TabIndex = 0;
            this.sweetRB.TabStop = true;
            this.sweetRB.Text = "Sweet";
            this.sweetRB.UseVisualStyleBackColor = true;
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.White;
            this.orderBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("orderBtn.BackgroundImage")));
            this.orderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.orderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderBtn.Location = new System.Drawing.Point(847, 422);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(137, 139);
            this.orderBtn.TabIndex = 5;
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // CoffeeRem
            // 
            this.CoffeeRem.Location = new System.Drawing.Point(92, 19);
            this.CoffeeRem.Name = "CoffeeRem";
            this.CoffeeRem.ReadOnly = true;
            this.CoffeeRem.Size = new System.Drawing.Size(100, 22);
            this.CoffeeRem.TabIndex = 6;
            // 
            // WaterRem
            // 
            this.WaterRem.Location = new System.Drawing.Point(92, 67);
            this.WaterRem.Name = "WaterRem";
            this.WaterRem.ReadOnly = true;
            this.WaterRem.Size = new System.Drawing.Size(100, 22);
            this.WaterRem.TabIndex = 7;
            // 
            // MilkRem
            // 
            this.MilkRem.Location = new System.Drawing.Point(92, 110);
            this.MilkRem.Name = "MilkRem";
            this.MilkRem.ReadOnly = true;
            this.MilkRem.Size = new System.Drawing.Size(100, 22);
            this.MilkRem.TabIndex = 8;
            // 
            // SugarRem
            // 
            this.SugarRem.Location = new System.Drawing.Point(92, 149);
            this.SugarRem.Name = "SugarRem";
            this.SugarRem.ReadOnly = true;
            this.SugarRem.Size = new System.Drawing.Size(100, 22);
            this.SugarRem.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(995, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.BackColor = System.Drawing.Color.White;
            this.infoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infoBtn.BackgroundImage")));
            this.infoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.infoBtn.Location = new System.Drawing.Point(995, 17);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(92, 87);
            this.infoBtn.TabIndex = 11;
            this.infoBtn.UseVisualStyleBackColor = false;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Coffee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Water";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Milk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sugar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(843, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 161);
            this.label5.TabIndex = 16;
            this.label5.Text = "Press me to order \r\n               |\r\n               |\r\n           \\      /\r\n    " +
    "         \\  / \r\n               \r\n              \r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1109, 740);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SugarRem);
            this.Controls.Add(this.MilkRem);
            this.Controls.Add(this.WaterRem);
            this.Controls.Add(this.CoffeeRem);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton americanoRB;
        private System.Windows.Forms.RadioButton cappucinoRB;
        private System.Windows.Forms.RadioButton espressoRB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton sugarFreeRB;
        private System.Windows.Forms.RadioButton semiSweetRB;
        private System.Windows.Forms.RadioButton sweetRB;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.TextBox CoffeeRem;
        private System.Windows.Forms.TextBox WaterRem;
        private System.Windows.Forms.TextBox MilkRem;
        private System.Windows.Forms.TextBox SugarRem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

