namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addition = new System.Windows.Forms.Button();
            this.sabtraction = new System.Windows.Forms.Button();
            this.multyplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(12, 85);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(75, 23);
            this.addition.TabIndex = 0;
            this.addition.Text = "Сложение";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.Click);
            // 
            // sabtraction
            // 
            this.sabtraction.Location = new System.Drawing.Point(191, 85);
            this.sabtraction.Name = "sabtraction";
            this.sabtraction.Size = new System.Drawing.Size(75, 23);
            this.sabtraction.TabIndex = 1;
            this.sabtraction.Text = "Вычитание ";
            this.sabtraction.UseVisualStyleBackColor = true;
            this.sabtraction.Click += new System.EventHandler(this.Click);
            // 
            // multyplication
            // 
            this.multyplication.Location = new System.Drawing.Point(13, 170);
            this.multyplication.Name = "multyplication";
            this.multyplication.Size = new System.Drawing.Size(75, 23);
            this.multyplication.TabIndex = 2;
            this.multyplication.Text = "Умножение";
            this.multyplication.UseVisualStyleBackColor = true;
            this.multyplication.Click += new System.EventHandler(this.Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(191, 170);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 23);
            this.division.TabIndex = 3;
            this.division.Text = "Деление";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(191, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(81, 20);
            this.textBox3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multyplication);
            this.Controls.Add(this.sabtraction);
            this.Controls.Add(this.addition);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button sabtraction;
        private System.Windows.Forms.Button multyplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

