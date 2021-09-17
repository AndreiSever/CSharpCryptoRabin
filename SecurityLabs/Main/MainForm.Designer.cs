namespace SecurityLabs
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.bruteForce = new System.Windows.Forms.Button();
            this.btnLegendre = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.cmbBrigade = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "RSA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bruteForce
            // 
            this.bruteForce.Location = new System.Drawing.Point(51, 64);
            this.bruteForce.Name = "bruteForce";
            this.bruteForce.Size = new System.Drawing.Size(175, 23);
            this.bruteForce.TabIndex = 1;
            this.bruteForce.Text = "Полный перебор";
            this.bruteForce.UseVisualStyleBackColor = true;
            this.bruteForce.Click += new System.EventHandler(this.bruteForce_Click);
            // 
            // btnLegendre
            // 
            this.btnLegendre.Location = new System.Drawing.Point(51, 93);
            this.btnLegendre.Name = "btnLegendre";
            this.btnLegendre.Size = new System.Drawing.Size(175, 23);
            this.btnLegendre.TabIndex = 2;
            this.btnLegendre.Text = "Символы Лежандра";
            this.btnLegendre.UseVisualStyleBackColor = true;
            this.btnLegendre.Click += new System.EventHandler(this.btnLegendre_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(344, 37);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 21);
            this.cmbYear.TabIndex = 3;
            // 
            // cmbSemester
            // 
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(344, 66);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(121, 21);
            this.cmbSemester.TabIndex = 4;
            // 
            // cmbBrigade
            // 
            this.cmbBrigade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrigade.FormattingEnabled = true;
            this.cmbBrigade.Location = new System.Drawing.Point(344, 95);
            this.cmbBrigade.Name = "cmbBrigade";
            this.cmbBrigade.Size = new System.Drawing.Size(121, 21);
            this.cmbBrigade.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Полиалфавитный";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Год";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Семестр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Бригада";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(51, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Моноалфавитный";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(51, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Вероятные слова";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(51, 211);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Метод рюкзака";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(51, 241);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Дискретные логарифмы";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(51, 271);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(175, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Алгоритм Рабина";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 573);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbBrigade);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.btnLegendre);
            this.Controls.Add(this.bruteForce);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bruteForce;
        private System.Windows.Forms.Button btnLegendre;
        public System.Windows.Forms.ComboBox cmbSemester;
        public System.Windows.Forms.ComboBox cmbBrigade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

