namespace CS_Area
{
    partial class StartWith
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
            this.btnStarts = new System.Windows.Forms.Button();
            this.txtSecondString = new System.Windows.Forms.TextBox();
            this.txtFirstString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(450, 170);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(343, 170);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStarts
            // 
            this.btnStarts.Location = new System.Drawing.Point(224, 170);
            this.btnStarts.Name = "btnStarts";
            this.btnStarts.Size = new System.Drawing.Size(91, 34);
            this.btnStarts.TabIndex = 32;
            this.btnStarts.Text = "Starts";
            this.btnStarts.UseVisualStyleBackColor = true;
            this.btnStarts.Click += new System.EventHandler(this.btnStarts_Click);
            // 
            // txtSecondString
            // 
            this.txtSecondString.Location = new System.Drawing.Point(380, 95);
            this.txtSecondString.Multiline = true;
            this.txtSecondString.Name = "txtSecondString";
            this.txtSecondString.ReadOnly = true;
            this.txtSecondString.Size = new System.Drawing.Size(168, 29);
            this.txtSecondString.TabIndex = 31;
            // 
            // txtFirstString
            // 
            this.txtFirstString.Location = new System.Drawing.Point(380, 48);
            this.txtFirstString.Multiline = true;
            this.txtFirstString.Name = "txtFirstString";
            this.txtFirstString.Size = new System.Drawing.Size(168, 31);
            this.txtFirstString.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Starts with string";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Enter Your Name";
            // 
            // StartWith
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 324);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStarts);
            this.Controls.Add(this.txtSecondString);
            this.Controls.Add(this.txtFirstString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StartWith";
            this.Text = "StartWith";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStarts;
        private System.Windows.Forms.TextBox txtSecondString;
        private System.Windows.Forms.TextBox txtFirstString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}