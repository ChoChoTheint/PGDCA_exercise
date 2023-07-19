namespace squareArea
{
    partial class numberTxt
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
            this.number = new System.Windows.Forms.Label();
            this.numTxt = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.Label();
            this.answerTxt = new System.Windows.Forms.TextBox();
            this.square = new System.Windows.Forms.Button();
            this.cube = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(267, 36);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(58, 17);
            this.number.TabIndex = 0;
            this.number.Text = "Number";
            // 
            // numTxt
            // 
            this.numTxt.Location = new System.Drawing.Point(347, 33);
            this.numTxt.Name = "numTxt";
            this.numTxt.Size = new System.Drawing.Size(264, 22);
            this.numTxt.TabIndex = 1;
            this.numTxt.TextChanged += new System.EventHandler(this.numTxt_TextChanged);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(267, 86);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(54, 17);
            this.answer.TabIndex = 2;
            this.answer.Text = "Answer";
            // 
            // answerTxt
            // 
            this.answerTxt.Location = new System.Drawing.Point(347, 86);
            this.answerTxt.Name = "answerTxt";
            this.answerTxt.Size = new System.Drawing.Size(264, 22);
            this.answerTxt.TabIndex = 3;
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(270, 143);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(75, 23);
            this.square.TabIndex = 4;
            this.square.Text = "Square";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // cube
            // 
            this.cube.Location = new System.Drawing.Point(402, 143);
            this.cube.Name = "cube";
            this.cube.Size = new System.Drawing.Size(75, 23);
            this.cube.TabIndex = 5;
            this.cube.Text = "Cube";
            this.cube.UseVisualStyleBackColor = true;
            this.cube.Click += new System.EventHandler(this.cube_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(536, 143);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 6;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // numberTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 253);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.cube);
            this.Controls.Add(this.square);
            this.Controls.Add(this.answerTxt);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.numTxt);
            this.Controls.Add(this.number);
            this.Name = "numberTxt";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label number;
        private System.Windows.Forms.TextBox numTxt;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.TextBox answerTxt;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button cube;
        private System.Windows.Forms.Button clear;
    }
}

