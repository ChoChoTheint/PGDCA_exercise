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
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.listSubject = new System.Windows.Forms.ListBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.clsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboSubject
            // 
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Items.AddRange(new object[] {
            "Semester I",
            "Semester II"});
            this.cboSubject.Location = new System.Drawing.Point(46, 34);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(121, 24);
            this.cboSubject.TabIndex = 0;
            this.cboSubject.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listSubject
            // 
            this.listSubject.FormattingEnabled = true;
            this.listSubject.ItemHeight = 16;
            this.listSubject.Location = new System.Drawing.Point(257, 34);
            this.listSubject.Name = "listSubject";
            this.listSubject.Size = new System.Drawing.Size(200, 84);
            this.listSubject.TabIndex = 1;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(257, 145);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // clsBtn
            // 
            this.clsBtn.Location = new System.Drawing.Point(362, 145);
            this.clsBtn.Name = "clsBtn";
            this.clsBtn.Size = new System.Drawing.Size(66, 23);
            this.clsBtn.TabIndex = 3;
            this.clsBtn.Text = "Close";
            this.clsBtn.UseVisualStyleBackColor = true;
            this.clsBtn.Click += new System.EventHandler(this.clsBtn_Click);
            // 
            // Using_ComboBox_and_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 253);
            this.Controls.Add(this.clsBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.listSubject);
            this.Controls.Add(this.cboSubject);
            this.Name = "Using_ComboBox_and_ListBox";
            this.Text = "Using_ComboBox_and_ListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.ListBox listSubject;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button clsBtn;
    }
}