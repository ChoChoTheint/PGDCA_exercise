namespace CS_Area
{
    partial class TotalPayment
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegHr = new System.Windows.Forms.TextBox();
            this.txtOvtHr = new System.Windows.Forms.TextBox();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.clickBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Regular Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Overtime Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pay Rate";
            // 
            // txtRegHr
            // 
            this.txtRegHr.Location = new System.Drawing.Point(261, 52);
            this.txtRegHr.Name = "txtRegHr";
            this.txtRegHr.Size = new System.Drawing.Size(100, 22);
            this.txtRegHr.TabIndex = 4;
            // 
            // txtOvtHr
            // 
            this.txtOvtHr.Location = new System.Drawing.Point(261, 94);
            this.txtOvtHr.Name = "txtOvtHr";
            this.txtOvtHr.Size = new System.Drawing.Size(100, 22);
            this.txtOvtHr.TabIndex = 5;
            // 
            // txtPayRate
            // 
            this.txtPayRate.Location = new System.Drawing.Point(261, 141);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(100, 22);
            this.txtPayRate.TabIndex = 6;
            // 
            // clickBtn
            // 
            this.clickBtn.Location = new System.Drawing.Point(157, 201);
            this.clickBtn.Name = "clickBtn";
            this.clickBtn.Size = new System.Drawing.Size(77, 40);
            this.clickBtn.TabIndex = 7;
            this.clickBtn.Text = "Click";
            this.clickBtn.UseVisualStyleBackColor = true;
            this.clickBtn.Click += new System.EventHandler(this.clickBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(261, 201);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(81, 38);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // TotalPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 405);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.clickBtn);
            this.Controls.Add(this.txtPayRate);
            this.Controls.Add(this.txtOvtHr);
            this.Controls.Add(this.txtRegHr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TotalPayment";
            this.Text = "TotalPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegHr;
        private System.Windows.Forms.TextBox txtOvtHr;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.Button clickBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}