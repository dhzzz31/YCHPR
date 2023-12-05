namespace pr2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_c = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_dx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_xk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_x0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(495, 331);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "Вычесление";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(643, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 31);
            this.button2.TabIndex = 19;
            this.button2.Text = "Новая форма";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(533, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 342);
            this.listBox1.TabIndex = 20;
            // 
            // textBox_c
            // 
            this.textBox_c.Location = new System.Drawing.Point(429, 390);
            this.textBox_c.Multiline = true;
            this.textBox_c.Name = "textBox_c";
            this.textBox_c.Size = new System.Drawing.Size(78, 20);
            this.textBox_c.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(273, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "a";
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(345, 390);
            this.textBox_b.Multiline = true;
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(78, 20);
            this.textBox_b.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(351, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "b";
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(261, 390);
            this.textBox_a.Multiline = true;
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(78, 20);
            this.textBox_a.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(429, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "c";
            // 
            // textBox_dx
            // 
            this.textBox_dx.Location = new System.Drawing.Point(177, 390);
            this.textBox_dx.Multiline = true;
            this.textBox_dx.Name = "textBox_dx";
            this.textBox_dx.Size = new System.Drawing.Size(78, 20);
            this.textBox_dx.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(177, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "dx";
            // 
            // textBox_xk
            // 
            this.textBox_xk.Location = new System.Drawing.Point(93, 390);
            this.textBox_xk.Multiline = true;
            this.textBox_xk.Name = "textBox_xk";
            this.textBox_xk.Size = new System.Drawing.Size(78, 20);
            this.textBox_xk.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(93, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Xk";
            // 
            // textbox_x0
            // 
            this.textbox_x0.Location = new System.Drawing.Point(9, 390);
            this.textbox_x0.Multiline = true;
            this.textbox_x0.Name = "textbox_x0";
            this.textbox_x0.Size = new System.Drawing.Size(78, 20);
            this.textbox_x0.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "X0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 437);
            this.Controls.Add(this.textBox_c);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_dx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_xk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_x0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "у=ax^2+bx+c";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox_c;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_dx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_xk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_x0;
        private System.Windows.Forms.Label label1;
    }
}

