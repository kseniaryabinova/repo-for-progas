namespace methods_of_optimisation
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
            this.button1 = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.equation = new System.Windows.Forms.ComboBox();
            this.vector = new System.Windows.Forms.ComboBox();
            this.eps2 = new System.Windows.Forms.TextBox();
            this.eps1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 707);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(726, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Найти минимум";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // output
            // 
            this.output.AllowDrop = true;
            this.output.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output.Location = new System.Drawing.Point(12, 253);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(726, 431);
            this.output.TabIndex = 6;
            this.output.TabStop = false;
            this.output.Text = "Результат";
            // 
            // equation
            // 
            this.equation.AllowDrop = true;
            this.equation.BackColor = System.Drawing.SystemColors.HighlightText;
            this.equation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.equation.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equation.FormattingEnabled = true;
            this.equation.Location = new System.Drawing.Point(12, 110);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(726, 34);
            this.equation.TabIndex = 1;
            this.equation.Text = "введите функцию";
            this.equation.Leave += new System.EventHandler(this.equation_Leave);
            // 
            // vector
            // 
            this.vector.AllowDrop = true;
            this.vector.BackColor = System.Drawing.SystemColors.HighlightText;
            this.vector.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.vector.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vector.FormattingEnabled = true;
            this.vector.Location = new System.Drawing.Point(12, 150);
            this.vector.Name = "vector";
            this.vector.Size = new System.Drawing.Size(726, 34);
            this.vector.TabIndex = 2;
            this.vector.Text = "введите вектор начального приближения";
            this.vector.Leave += new System.EventHandler(this.vector_Leave);
            // 
            // eps2
            // 
            this.eps2.Dock = System.Windows.Forms.DockStyle.Right;
            this.eps2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eps2.Location = new System.Drawing.Point(368, 0);
            this.eps2.Name = "eps2";
            this.eps2.Size = new System.Drawing.Size(358, 32);
            this.eps2.TabIndex = 4;
            this.eps2.Text = "0,15";
            // 
            // eps1
            // 
            this.eps1.Dock = System.Windows.Forms.DockStyle.Left;
            this.eps1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eps1.Location = new System.Drawing.Point(0, 0);
            this.eps1.Name = "eps1";
            this.eps1.Size = new System.Drawing.Size(362, 32);
            this.eps1.TabIndex = 3;
            this.eps1.Text = "0,1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.eps1);
            this.panel1.Controls.Add(this.eps2);
            this.panel1.Location = new System.Drawing.Point(12, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 35);
            this.panel1.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(6, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(213, 27);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "Наискорейшего спуска";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(247, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(161, 27);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "Фледчера-Ривса";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(546, 42);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(174, 27);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Ньютона-Равсона";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(425, 42);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(102, 27);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.Text = "Ньютона";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(726, 92);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Методы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vector);
            this.Controls.Add(this.output);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "методы оптимизации";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.ComboBox equation;
        private System.Windows.Forms.ComboBox vector;
        private System.Windows.Forms.TextBox eps2;
        private System.Windows.Forms.TextBox eps1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

