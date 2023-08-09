namespace CS_Area
{
    partial class UpperAndLower
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
            this.btnUpper = new System.Windows.Forms.Button();
            this.txtSecondString = new System.Windows.Forms.TextBox();
            this.txtFirstString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLower = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(474, 243);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(380, 243);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpper
            // 
            this.btnUpper.Location = new System.Drawing.Point(271, 243);
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Size = new System.Drawing.Size(91, 34);
            this.btnUpper.TabIndex = 25;
            this.btnUpper.Text = "ToUpper";
            this.btnUpper.UseVisualStyleBackColor = true;
            this.btnUpper.Click += new System.EventHandler(this.btnUpper_Click);
            // 
            // txtSecondString
            // 
            this.txtSecondString.Location = new System.Drawing.Point(368, 168);
            this.txtSecondString.Multiline = true;
            this.txtSecondString.Name = "txtSecondString";
            this.txtSecondString.ReadOnly = true;
            this.txtSecondString.Size = new System.Drawing.Size(168, 29);
            this.txtSecondString.TabIndex = 24;
            // 
            // txtFirstString
            // 
            this.txtFirstString.Location = new System.Drawing.Point(368, 121);
            this.txtFirstString.Multiline = true;
            this.txtFirstString.Name = "txtFirstString";
            this.txtFirstString.Size = new System.Drawing.Size(168, 31);
            this.txtFirstString.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Second String";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "First String";
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(168, 243);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(84, 34);
            this.btnLower.TabIndex = 28;
            this.btnLower.Text = "ToLower";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // UpperAndLower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 399);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpper);
            this.Controls.Add(this.txtSecondString);
            this.Controls.Add(this.txtFirstString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpperAndLower";
            this.Text = "UpperAndLower";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpper;
        private System.Windows.Forms.TextBox txtSecondString;
        private System.Windows.Forms.TextBox txtFirstString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLower;
    }
}