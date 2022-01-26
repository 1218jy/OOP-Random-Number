namespace Random_Number
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
            this.randomBtn = new System.Windows.Forms.Button();
            this.tbt1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // randomBtn
            // 
            this.randomBtn.Location = new System.Drawing.Point(12, 61);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(160, 23);
            this.randomBtn.TabIndex = 0;
            this.randomBtn.Text = "Generate a random number";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            // 
            // tbt1
            // 
            this.tbt1.Location = new System.Drawing.Point(45, 24);
            this.tbt1.Name = "tbt1";
            this.tbt1.Size = new System.Drawing.Size(100, 20);
            this.tbt1.TabIndex = 1;
            this.tbt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbt1.TextChanged += new System.EventHandler(this.tbt1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 106);
            this.Controls.Add(this.tbt1);
            this.Controls.Add(this.randomBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.TextBox tbt1;
    }
}

