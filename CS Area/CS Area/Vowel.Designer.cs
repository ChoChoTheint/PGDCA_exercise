namespace CS_Area
{
    partial class Vowel
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnVowel = new System.Windows.Forms.Button();
            this.txtSecondString = new System.Windows.Forms.TextBox();
            this.txtFirstString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(458, 170);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(351, 170);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnVowel
            // 
            this.btnVowel.Location = new System.Drawing.Point(232, 170);
            this.btnVowel.Name = "btnVowel";
            this.btnVowel.Size = new System.Drawing.Size(91, 34);
            this.btnVowel.TabIndex = 39;
            this.btnVowel.Text = "Vowel";
            this.btnVowel.UseVisualStyleBackColor = true;
            this.btnVowel.Click += new System.EventHandler(this.btnVowel_Click);
            // 
            // txtSecondString
            // 
            this.txtSecondString.Location = new System.Drawing.Point(388, 95);
            this.txtSecondString.Multiline = true;
            this.txtSecondString.Name = "txtSecondString";
            this.txtSecondString.ReadOnly = true;
            this.txtSecondString.Size = new System.Drawing.Size(168, 29);
            this.txtSecondString.TabIndex = 38;
            // 
            // txtFirstString
            // 
            this.txtFirstString.Location = new System.Drawing.Point(388, 48);
            this.txtFirstString.Multiline = true;
            this.txtFirstString.Name = "txtFirstString";
            this.txtFirstString.Size = new System.Drawing.Size(168, 31);
            this.txtFirstString.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Vowel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Enter String";
            // 
            // Vowel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 253);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnVowel);
            this.Controls.Add(this.txtSecondString);
            this.Controls.Add(this.txtFirstString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Vowel";
            this.Text = "Vowel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnVowel;
        private System.Windows.Forms.TextBox txtSecondString;
        private System.Windows.Forms.TextBox txtFirstString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}