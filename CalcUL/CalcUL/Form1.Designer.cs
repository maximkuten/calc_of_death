namespace CalcUL
{
    partial class Form1
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
            this.First = new System.Windows.Forms.TextBox();
            this.Second = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.addition = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // First
            // 
            this.First.Location = new System.Drawing.Point(12, 23);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(100, 20);
            this.First.TabIndex = 0;
            // 
            // Second
            // 
            this.Second.Location = new System.Drawing.Point(118, 23);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(100, 20);
            this.Second.TabIndex = 1;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(239, 23);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 20);
            this.Result.TabIndex = 2;
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(12, 49);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(130, 51);
            this.addition.TabIndex = 3;
            this.addition.Text = "Сложение";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // subtraction
            // 
            this.subtraction.Location = new System.Drawing.Point(203, 49);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(127, 51);
            this.subtraction.TabIndex = 4;
            this.subtraction.Text = "Вычитание";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(12, 106);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(130, 53);
            this.multiplication.TabIndex = 5;
            this.multiplication.Text = "Умножение";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(203, 106);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(127, 53);
            this.division.TabIndex = 6;
            this.division.Text = "Деление";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(133, 174);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 7;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 219);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.First);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox First;
        private System.Windows.Forms.TextBox Second;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button exit;
    }
}

