namespace CS_Area
{
    partial class CarRentalChargesInformation
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
            this.opt1 = new System.Windows.Forms.RadioButton();
            this.opt2 = new System.Windows.Forms.RadioButton();
            this.opt3 = new System.Windows.Forms.RadioButton();
            this.txtDay = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.calBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Of Car";
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.Location = new System.Drawing.Point(79, 79);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(144, 21);
            this.opt1.TabIndex = 1;
            this.opt1.TabStop = true;
            this.opt1.Text = "Hi way air con bus";
            this.opt1.UseVisualStyleBackColor = true;
            this.opt1.CheckedChanged += new System.EventHandler(this.opt1_CheckedChanged);
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.Location = new System.Drawing.Point(79, 118);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(81, 21);
            this.opt2.TabIndex = 2;
            this.opt2.TabStop = true;
            this.opt2.Text = "Mini bus";
            this.opt2.UseVisualStyleBackColor = true;
            this.opt2.CheckedChanged += new System.EventHandler(this.opt2_CheckedChanged);
            // 
            // opt3
            // 
            this.opt3.AutoSize = true;
            this.opt3.Location = new System.Drawing.Point(79, 156);
            this.opt3.Name = "opt3";
            this.opt3.Size = new System.Drawing.Size(73, 21);
            this.opt3.TabIndex = 3;
            this.opt3.TabStop = true;
            this.opt3.Text = "Saloon";
            this.opt3.UseVisualStyleBackColor = true;
            this.opt3.CheckedChanged += new System.EventHandler(this.opt3_CheckedChanged);
            // 
            // txtDay
            // 
            this.txtDay.AutoSize = true;
            this.txtDay.Location = new System.Drawing.Point(21, 203);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(110, 17);
            this.txtDay.TabIndex = 4;
            this.txtDay.Text = "Number of Days";
            this.txtDay.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(137, 203);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(118, 22);
            this.txtDays.TabIndex = 5;
            // 
            // calBtn
            // 
            this.calBtn.Location = new System.Drawing.Point(42, 245);
            this.calBtn.Name = "calBtn";
            this.calBtn.Size = new System.Drawing.Size(75, 23);
            this.calBtn.TabIndex = 6;
            this.calBtn.Text = "Calculate";
            this.calBtn.UseVisualStyleBackColor = true;
            this.calBtn.Click += new System.EventHandler(this.calBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(148, 245);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // CarRentalChargesInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 325);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.calBtn);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.opt3);
            this.Controls.Add(this.opt2);
            this.Controls.Add(this.opt1);
            this.Controls.Add(this.label1);
            this.Name = "CarRentalChargesInformation";
            this.Text = "CarRentalChargesInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton opt1;
        private System.Windows.Forms.RadioButton opt2;
        private System.Windows.Forms.RadioButton opt3;
        private System.Windows.Forms.Label txtDay;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Button calBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}