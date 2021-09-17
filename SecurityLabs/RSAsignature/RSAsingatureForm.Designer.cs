namespace SecurityLabs
{
    partial class RSAsingatureForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.buttonGetTask = new System.Windows.Forms.Button();
            this.buttonExample = new System.Windows.Forms.Button();
            this.buttonTask = new System.Windows.Forms.Button();
            this.buttonTheory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(12, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(724, 391);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Location = new System.Drawing.Point(388, 12);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(75, 23);
            this.buttonAnswer.TabIndex = 14;
            this.buttonAnswer.Text = "Ответ";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // buttonGetTask
            // 
            this.buttonGetTask.Location = new System.Drawing.Point(274, 12);
            this.buttonGetTask.Name = "buttonGetTask";
            this.buttonGetTask.Size = new System.Drawing.Size(108, 23);
            this.buttonGetTask.TabIndex = 13;
            this.buttonGetTask.Text = "Получить задание";
            this.buttonGetTask.UseVisualStyleBackColor = true;
            this.buttonGetTask.Click += new System.EventHandler(this.buttonGetTask_Click);
            // 
            // buttonExample
            // 
            this.buttonExample.Location = new System.Drawing.Point(193, 12);
            this.buttonExample.Name = "buttonExample";
            this.buttonExample.Size = new System.Drawing.Size(75, 23);
            this.buttonExample.TabIndex = 12;
            this.buttonExample.Text = "Пример";
            this.buttonExample.UseVisualStyleBackColor = true;
            this.buttonExample.Click += new System.EventHandler(this.buttonExample_Click);
            // 
            // buttonTask
            // 
            this.buttonTask.Location = new System.Drawing.Point(92, 12);
            this.buttonTask.Name = "buttonTask";
            this.buttonTask.Size = new System.Drawing.Size(95, 23);
            this.buttonTask.TabIndex = 11;
            this.buttonTask.Text = "Текст задания";
            this.buttonTask.UseVisualStyleBackColor = true;
            this.buttonTask.Click += new System.EventHandler(this.buttonTask_Click);
            // 
            // buttonTheory
            // 
            this.buttonTheory.Location = new System.Drawing.Point(11, 12);
            this.buttonTheory.Name = "buttonTheory";
            this.buttonTheory.Size = new System.Drawing.Size(75, 23);
            this.buttonTheory.TabIndex = 10;
            this.buttonTheory.Text = "Теория";
            this.buttonTheory.UseVisualStyleBackColor = true;
            this.buttonTheory.Click += new System.EventHandler(this.buttonTheory_Click);
            // 
            // RSAsingatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 444);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.buttonGetTask);
            this.Controls.Add(this.buttonExample);
            this.Controls.Add(this.buttonTask);
            this.Controls.Add(this.buttonTheory);
            this.Controls.Add(this.richTextBox1);
            this.MinimumSize = new System.Drawing.Size(480, 200);
            this.Name = "RSAsingatureForm";
            this.Text = "RSAsingature";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.Button buttonGetTask;
        private System.Windows.Forms.Button buttonExample;
        private System.Windows.Forms.Button buttonTask;
        private System.Windows.Forms.Button buttonTheory;
    }
}