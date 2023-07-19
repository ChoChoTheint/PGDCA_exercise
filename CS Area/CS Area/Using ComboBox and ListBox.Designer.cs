namespace CS_Area
{
    partial class Using_ComboBox_and_ListBox
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
            this.stSubject = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // stSubject
            // 
            this.stSubject.FormattingEnabled = true;
            this.stSubject.Items.AddRange(new object[] {
            "Semester I",
            "Semester II"});
            this.stSubject.Location = new System.Drawing.Point(46, 34);
            this.stSubject.Name = "stSubject";
            this.stSubject.Size = new System.Drawing.Size(121, 24);
            this.stSubject.TabIndex = 0;
            this.stSubject.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Using_ComboBox_and_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 253);
            this.Controls.Add(this.stSubject);
            this.Name = "Using_ComboBox_and_ListBox";
            this.Text = "Using_ComboBox_and_ListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox stSubject;
    }
}