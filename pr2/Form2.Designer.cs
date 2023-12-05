namespace pr2
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
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
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(500, 315);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(568, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 329);
            this.listBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вычесление ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_dx
            // 
            this.textBox_dx.Location = new System.Drawing.Point(180, 395);
            this.textBox_dx.Multiline = true;
            this.textBox_dx.Name = "textBox_dx";
            this.textBox_dx.Size = new System.Drawing.Size(78, 20);
            this.textBox_dx.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(180, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "dx";
            // 
            // textBox_xk
            // 
            this.textBox_xk.Location = new System.Drawing.Point(96, 395);
            this.textBox_xk.Multiline = true;
            this.textBox_xk.Name = "textBox_xk";
            this.textBox_xk.Size = new System.Drawing.Size(78, 20);
            this.textBox_xk.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(96, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Xk";
            // 
            // textbox_x0
            // 
            this.textbox_x0.Location = new System.Drawing.Point(12, 395);
            this.textbox_x0.Multiline = true;
            this.textbox_x0.Name = "textbox_x0";
            this.textbox_x0.Size = new System.Drawing.Size(78, 20);
            this.textbox_x0.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "X0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_dx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_xk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_x0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.chart1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_dx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_xk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_x0;
        private System.Windows.Forms.Label label1;
    }
}