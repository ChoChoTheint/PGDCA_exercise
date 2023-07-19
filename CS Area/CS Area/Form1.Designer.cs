namespace CS_Area
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
            this.Radius = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.clsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Radius
            // 
            this.Radius.AutoSize = true;
            this.Radius.Location = new System.Drawing.Point(67, 52);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(52, 17);
            this.Radius.TabIndex = 0;
            this.Radius.Text = "Radius";
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Location = new System.Drawing.Point(67, 94);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(38, 17);
            this.Area.TabIndex = 1;
            this.Area.Text = "Area";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(148, 52);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(169, 22);
            this.txtRadius.TabIndex = 2;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(148, 94);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(169, 22);
            this.txtArea.TabIndex = 3;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(116, 140);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 4;
            this.btn.Text = "Calcute";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // clsBtn
            // 
            this.clsBtn.Location = new System.Drawing.Point(213, 140);
            this.clsBtn.Name = "clsBtn";
            this.clsBtn.Size = new System.Drawing.Size(75, 23);
            this.clsBtn.TabIndex = 5;
            this.clsBtn.Text = "Clear";
            this.clsBtn.UseVisualStyleBackColor = true;
            this.clsBtn.Click += new System.EventHandler(this.clsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 253);
            this.Controls.Add(this.clsBtn);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.Radius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Radius;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button clsBtn;
    }
}

