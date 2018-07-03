namespace Calculator
{
    partial class calc
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
            this.Cos = new System.Windows.Forms.Button();
            this.Tg = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.Log10 = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Abs = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Cube = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(119, 157);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(75, 23);
            this.addition.TabIndex = 0;
            this.addition.Text = "Сложение";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.Click);
            // 
            // sabtraction
            // 
            this.sabtraction.Location = new System.Drawing.Point(38, 186);
            this.sabtraction.Name = "sabtraction";
            this.sabtraction.Size = new System.Drawing.Size(75, 23);
            this.sabtraction.TabIndex = 1;
            this.sabtraction.Text = "Вычитание ";
            this.sabtraction.UseVisualStyleBackColor = true;
            this.sabtraction.Click += new System.EventHandler(this.Click);
            // 
            // multyplication
            // 
            this.multyplication.Location = new System.Drawing.Point(38, 157);
            this.multyplication.Name = "multyplication";
            this.multyplication.Size = new System.Drawing.Size(75, 23);
            this.multyplication.TabIndex = 2;
            this.multyplication.Text = "Умножение";
            this.multyplication.UseVisualStyleBackColor = true;
            this.multyplication.Click += new System.EventHandler(this.Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(119, 186);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 23);
            this.division.TabIndex = 3;
            this.division.Text = "Деление";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(165, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(81, 20);
            this.textBox3.TabIndex = 6;
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(155, 60);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(65, 23);
            this.Cos.TabIndex = 8;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.Click1);
            // 
            // Tg
            // 
            this.Tg.Location = new System.Drawing.Point(84, 60);
            this.Tg.Name = "Tg";
            this.Tg.Size = new System.Drawing.Size(65, 23);
            this.Tg.TabIndex = 9;
            this.Tg.Text = "Tg";
            this.Tg.UseVisualStyleBackColor = true;
            this.Tg.Click += new System.EventHandler(this.Click1);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(13, 60);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(65, 23);
            this.Sin.TabIndex = 10;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.Click1);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(155, 89);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(65, 23);
            this.Log.TabIndex = 11;
            this.Log.Text = "Log";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.Click1);
            // 
            // Log10
            // 
            this.Log10.Location = new System.Drawing.Point(84, 89);
            this.Log10.Name = "Log10";
            this.Log10.Size = new System.Drawing.Size(65, 23);
            this.Log10.TabIndex = 12;
            this.Log10.Text = "Log10";
            this.Log10.UseVisualStyleBackColor = true;
            this.Log10.Click += new System.EventHandler(this.Click1);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(13, 89);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(65, 23);
            this.Sqrt.TabIndex = 13;
            this.Sqrt.Text = "Sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Click1);
            // 
            // Abs
            // 
            this.Abs.Location = new System.Drawing.Point(155, 118);
            this.Abs.Name = "Abs";
            this.Abs.Size = new System.Drawing.Size(65, 23);
            this.Abs.TabIndex = 14;
            this.Abs.Text = "Abs";
            this.Abs.UseVisualStyleBackColor = true;
            this.Abs.Click += new System.EventHandler(this.Click1);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(84, 118);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(65, 23);
            this.Square.TabIndex = 15;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Click1);
            // 
            // Cube
            // 
            this.Cube.Location = new System.Drawing.Point(13, 118);
            this.Cube.Name = "Cube";
            this.Cube.Size = new System.Drawing.Size(65, 23);
            this.Cube.TabIndex = 16;
            this.Cube.Text = "Cube";
            this.Cube.UseVisualStyleBackColor = true;
            this.Cube.Click += new System.EventHandler(this.Click1);
            // 
            // calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 224);
            this.Controls.Add(this.Cube);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Abs);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Log10);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Tg);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multyplication);
            this.Controls.Add(this.sabtraction);
            this.Controls.Add(this.addition);
            this.Name = "calc";
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
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Tg;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Button Log10;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Abs;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Cube;
    }
}

