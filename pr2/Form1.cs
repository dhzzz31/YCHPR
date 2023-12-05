using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            chart1.Series[0].Points.Clear();

            double x0;
            double xk;
            double dx;
            double a;
            double b;
            double c;


            if (!double.TryParse(textbox_x0.Text, out x0) || !double.TryParse(textBox_xk.Text, out xk) || !double.TryParse(textBox_dx.Text, out dx) || !double.TryParse(textBox_a.Text, out a) || !double.TryParse(textBox_b.Text, out b) || !double.TryParse(textBox_c.Text, out c))
            {
                MessageBox.Show("Неправильно введенны данные");
                return;
            }

            chart1.ChartAreas[0].AxisX.Minimum = x0;
            chart1.ChartAreas[0].AxisX.Maximum = xk;

            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = dx;

            double x = x0;

            while (x <= (xk + dx / 2))
            {
                double y = a * Math.Pow(x, 2) + b * x + c;

                chart1.Series[0].Points.AddXY(x, y);
                listBox1.Items.Add($"x={x}\ty={Math.Round(y, 2)}\n");

                x += dx;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
