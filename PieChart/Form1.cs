using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PieChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            textBoxFirstNum.Text = "1";
            textBoxSecondNum.Text = "20";

            Random rd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int randomNum = rd.Next(1, 20);
                chart1.Series[0].Points.AddY(randomNum);
                chart1.Series[0].Points[i].LegendText = (i + 1).ToString();
                chart1.Series[0].Points[i].Label = randomNum.ToString();
            }

        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            var firstNum = 0;
            var secondNum = 0;

            try
            {
                firstNum = byte.Parse(textBoxFirstNum.Text);
                secondNum = byte.Parse(textBoxSecondNum.Text);
            }
            catch
            {
                MessageBox.Show(
                    "Введите в поля диапазона положительные целые числа",
                    "Нет, не так",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);

                textBoxFirstNum.Text = string.Empty;
                textBoxSecondNum.Text = string.Empty;
                return;
            }

            Random rd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int randomNum = rd.Next(firstNum, secondNum);
                chart1.Series[0].Points[i].YValues[0] = randomNum;
                chart1.Series[0].Points[i].LegendText = (i + 1).ToString();
                chart1.Series[0].Points[i].Label = randomNum.ToString();
            }
        }
    }
}
