namespace CS_Area
{
    partial class DoWhile
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
            this.click = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // click
            // 
            this.click.Location = new System.Drawing.Point(90, 142);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(75, 23);
            this.click.TabIndex = 0;
            this.click.Text = "Click";
            this.click.UseVisualStyleBackColor = true;
            this.click.Click += new System.EventHandler(this.click_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(195, 142);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 1;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(165, 46);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(0, 17);
            this.txt.TabIndex = 2;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(111, 43);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtText.Size = new System.Drawing.Size(144, 90);
            this.txtText.TabIndex = 3;
            // 
            // DoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 381);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.close);
            this.Controls.Add(this.click);
            this.Name = "DoWhile";
            this.Text = "DoWhile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button click;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.TextBox txtText;
    }
}