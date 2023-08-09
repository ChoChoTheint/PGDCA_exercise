namespace CS_Area
{
    partial class ForLoop
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
            this.txrNumber = new System.Windows.Forms.TextBox();
            this.click = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txrNumber
            // 
            this.txrNumber.Location = new System.Drawing.Point(150, 32);
            this.txrNumber.Multiline = true;
            this.txrNumber.Name = "txrNumber";
            this.txrNumber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txrNumber.Size = new System.Drawing.Size(214, 84);
            this.txrNumber.TabIndex = 0;
            // 
            // click
            // 
            this.click.Location = new System.Drawing.Point(150, 146);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(75, 23);
            this.click.TabIndex = 1;
            this.click.Text = "Click";
            this.click.UseVisualStyleBackColor = true;
            this.click.Click += new System.EventHandler(this.click_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(272, 146);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 2;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // ForLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 374);
            this.Controls.Add(this.close);
            this.Controls.Add(this.click);
            this.Controls.Add(this.txrNumber);
            this.Name = "ForLoop";
            this.Text = "ForLoop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txrNumber;
        private System.Windows.Forms.Button click;
        private System.Windows.Forms.Button close;
    }
}