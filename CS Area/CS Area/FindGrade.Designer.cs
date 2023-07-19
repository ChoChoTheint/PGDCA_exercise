namespace CS_Area
{
    partial class FindGrade
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
            this.label1 = new System.Windows.Forms.Label();
            this.enterTxt = new System.Windows.Forms.TextBox();
            this.findGradeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Total Mark";
            // 
            // enterTxt
            // 
            this.enterTxt.Location = new System.Drawing.Point(227, 52);
            this.enterTxt.Name = "enterTxt";
            this.enterTxt.Size = new System.Drawing.Size(196, 22);
            this.enterTxt.TabIndex = 1;
            // 
            // findGradeBtn
            // 
            this.findGradeBtn.Location = new System.Drawing.Point(128, 107);
            this.findGradeBtn.Name = "findGradeBtn";
            this.findGradeBtn.Size = new System.Drawing.Size(98, 23);
            this.findGradeBtn.TabIndex = 2;
            this.findGradeBtn.Text = "Find Grade";
            this.findGradeBtn.UseVisualStyleBackColor = true;
            this.findGradeBtn.Click += new System.EventHandler(this.findGradeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(265, 107);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(97, 23);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // FindGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 253);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.findGradeBtn);
            this.Controls.Add(this.enterTxt);
            this.Controls.Add(this.label1);
            this.Name = "FindGrade";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterTxt;
        private System.Windows.Forms.Button findGradeBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}