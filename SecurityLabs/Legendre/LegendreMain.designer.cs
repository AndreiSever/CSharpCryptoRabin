namespace LegendreLab
{
    partial class LegendreMain
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
            this.btnTheory = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.btnExample = new System.Windows.Forms.Button();
            this.btnGetTask = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnTheory
            // 
            this.btnTheory.Location = new System.Drawing.Point(16, 13);
            this.btnTheory.Name = "btnTheory";
            this.btnTheory.Size = new System.Drawing.Size(75, 23);
            this.btnTheory.TabIndex = 1;
            this.btnTheory.Text = "Теория";
            this.btnTheory.UseVisualStyleBackColor = true;
            this.btnTheory.Click += new System.EventHandler(this.btnTheory_Click);
            // 
            // btnTask
            // 
            this.btnTask.Location = new System.Drawing.Point(97, 13);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(95, 23);
            this.btnTask.TabIndex = 2;
            this.btnTask.Text = "Текст задания";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // btnExample
            // 
            this.btnExample.Location = new System.Drawing.Point(198, 13);
            this.btnExample.Name = "btnExample";
            this.btnExample.Size = new System.Drawing.Size(75, 23);
            this.btnExample.TabIndex = 3;
            this.btnExample.Text = "Пример";
            this.btnExample.UseVisualStyleBackColor = true;
            this.btnExample.Click += new System.EventHandler(this.btnExample_Click);
            // 
            // btnGetTask
            // 
            this.btnGetTask.Location = new System.Drawing.Point(279, 13);
            this.btnGetTask.Name = "btnGetTask";
            this.btnGetTask.Size = new System.Drawing.Size(108, 23);
            this.btnGetTask.TabIndex = 4;
            this.btnGetTask.Text = "Получить задание";
            this.btnGetTask.UseVisualStyleBackColor = true;
            this.btnGetTask.Click += new System.EventHandler(this.btnGetTask_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(393, 13);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnAnswer.TabIndex = 5;
            this.btnAnswer.Text = "Ответ";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(12, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(781, 340);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // LegendreMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 394);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnGetTask);
            this.Controls.Add(this.btnExample);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.btnTheory);
            this.MinimumSize = new System.Drawing.Size(493, 362);
            this.Name = "LegendreMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вычисление символов Лежандра";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTheory;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button btnExample;
        private System.Windows.Forms.Button btnGetTask;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

