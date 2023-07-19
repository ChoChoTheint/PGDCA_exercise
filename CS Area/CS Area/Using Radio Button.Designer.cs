namespace CS_Area
{
    partial class Using_Radio_Button
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
            this.pgdcaRadionBtn = new System.Windows.Forms.RadioButton();
            this.ygnRadioBtn = new System.Windows.Forms.RadioButton();
            this.clickBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pgdcaRadionBtn
            // 
            this.pgdcaRadionBtn.AutoSize = true;
            this.pgdcaRadionBtn.Location = new System.Drawing.Point(143, 63);
            this.pgdcaRadionBtn.Name = "pgdcaRadionBtn";
            this.pgdcaRadionBtn.Size = new System.Drawing.Size(77, 21);
            this.pgdcaRadionBtn.TabIndex = 0;
            this.pgdcaRadionBtn.TabStop = true;
            this.pgdcaRadionBtn.Text = "PGDCA";
            this.pgdcaRadionBtn.UseVisualStyleBackColor = true;
            // 
            // ygnRadioBtn
            // 
            this.ygnRadioBtn.AutoSize = true;
            this.ygnRadioBtn.Location = new System.Drawing.Point(257, 63);
            this.ygnRadioBtn.Name = "ygnRadioBtn";
            this.ygnRadioBtn.Size = new System.Drawing.Size(144, 21);
            this.ygnRadioBtn.TabIndex = 1;
            this.ygnRadioBtn.TabStop = true;
            this.ygnRadioBtn.Text = "Yangon University";
            this.ygnRadioBtn.UseVisualStyleBackColor = true;
            // 
            // clickBtn
            // 
            this.clickBtn.Location = new System.Drawing.Point(200, 118);
            this.clickBtn.Name = "clickBtn";
            this.clickBtn.Size = new System.Drawing.Size(75, 23);
            this.clickBtn.TabIndex = 2;
            this.clickBtn.Text = "Click";
            this.clickBtn.UseVisualStyleBackColor = true;
            this.clickBtn.Click += new System.EventHandler(this.clickBtn_Click);
            // 
            // Using_Radio_Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 253);
            this.Controls.Add(this.clickBtn);
            this.Controls.Add(this.ygnRadioBtn);
            this.Controls.Add(this.pgdcaRadionBtn);
            this.Name = "Using_Radio_Button";
            this.Text = "Using_Radio_Button";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton pgdcaRadionBtn;
        private System.Windows.Forms.RadioButton ygnRadioBtn;
        private System.Windows.Forms.Button clickBtn;
    }
}