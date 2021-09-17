namespace RabinLab
{
    partial class RabinMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTheory = new System.Windows.Forms.Button();
            this.buttonTask = new System.Windows.Forms.Button();
            this.buttonExample = new System.Windows.Forms.Button();
            this.buttonGetTask = new System.Windows.Forms.Button();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonTheory
            // 
            this.buttonTheory.Location = new System.Drawing.Point(16, 13);
            this.buttonTheory.Name = "buttonTheory";
            this.buttonTheory.Size = new System.Drawing.Size(75, 23);
            this.buttonTheory.TabIndex = 1;
            this.buttonTheory.Text = "Теория";
            this.buttonTheory.UseVisualStyleBackColor = true;
            this.buttonTheory.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTask
            // 
            this.buttonTask.Location = new System.Drawing.Point(97, 13);
            this.buttonTask.Name = "buttonTask";
            this.buttonTask.Size = new System.Drawing.Size(95, 23);
            this.buttonTask.TabIndex = 2;
            this.buttonTask.Text = "Текст задания";
            this.buttonTask.UseVisualStyleBackColor = true;
            this.buttonTask.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonExample
            // 
            this.buttonExample.Location = new System.Drawing.Point(198, 13);
            this.buttonExample.Name = "buttonExample";
            this.buttonExample.Size = new System.Drawing.Size(75, 23);
            this.buttonExample.TabIndex = 3;
            this.buttonExample.Text = "Пример";
            this.buttonExample.UseVisualStyleBackColor = true;
            this.buttonExample.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonGetTask
            // 
            this.buttonGetTask.Location = new System.Drawing.Point(279, 13);
            this.buttonGetTask.Name = "buttonGetTask";
            this.buttonGetTask.Size = new System.Drawing.Size(108, 23);
            this.buttonGetTask.TabIndex = 4;
            this.buttonGetTask.Text = "Получить задание";
            this.buttonGetTask.UseVisualStyleBackColor = true;
            this.buttonGetTask.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Location = new System.Drawing.Point(393, 13);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(75, 23);
            this.buttonAnswer.TabIndex = 5;
            this.buttonAnswer.Text = "Ответ";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.button5_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(12, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(781, 323);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // RabinMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 394);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.buttonGetTask);
            this.Controls.Add(this.buttonExample);
            this.Controls.Add(this.buttonTask);
            this.Controls.Add(this.buttonTheory);
            this.MinimumSize = new System.Drawing.Size(493, 362);
            this.Name = "RabinMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Алгоритм Рабина";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTheory;
        private System.Windows.Forms.Button buttonTask;
        private System.Windows.Forms.Button buttonExample;
        private System.Windows.Forms.Button buttonGetTask;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

