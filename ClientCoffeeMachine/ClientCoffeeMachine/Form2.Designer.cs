namespace ClientCoffeeMachine
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveToWordFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1140, 732);
            this.textBox1.TabIndex = 0;
            // 
            // saveToWordFile
            // 
            this.saveToWordFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveToWordFile.ForeColor = System.Drawing.Color.RosyBrown;
            this.saveToWordFile.Location = new System.Drawing.Point(1180, 209);
            this.saveToWordFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveToWordFile.Name = "saveToWordFile";
            this.saveToWordFile.Size = new System.Drawing.Size(94, 62);
            this.saveToWordFile.TabIndex = 1;
            this.saveToWordFile.Text = "Save to Word";
            this.saveToWordFile.UseVisualStyleBackColor = false;
            this.saveToWordFile.Click += new System.EventHandler(this.saveToWordFile_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 776);
            this.Controls.Add(this.saveToWordFile);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button saveToWordFile;
    }
}