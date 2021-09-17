namespace BruteForceLab
{
    partial class BruteForceAnswer
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
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.Check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnswerBox
            // 
            this.AnswerBox.Location = new System.Drawing.Point(13, 13);
            this.AnswerBox.Multiline = true;
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AnswerBox.Size = new System.Drawing.Size(267, 203);
            this.AnswerBox.TabIndex = 0;
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(106, 222);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(75, 23);
            this.Check.TabIndex = 1;
            this.Check.Text = "Проверить";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.button1_Click);
            // 
            // BruteForceAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 254);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.AnswerBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BruteForceAnswer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ответ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.Button Check;
    }
}