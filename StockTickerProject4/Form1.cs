using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StockTickerProject4
{
    public partial class Form1 : Form
    {
        double x;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += timer1_Tick;
            timer1.Interval = 50;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                timer1.Start();
            
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            List<string> MSFT1 = Program.CSV.MSFT_Price();
            List<string> MSFT2 = Program.CSV.MSFT_Dates();


            //chart1.Series[0].Points.AddXY(x, 3+ Math.Sin(x + 3));
            chart1.Series[0].Points.DataBindXY(MSFT2,MSFT1);

            if (chart1.Series[0].Points.Count > 100)
                chart1.Series[0].Points.RemoveAt(0);

            //chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points[0].XValue;
            //chart1.ChartAreas[0].AxisX.Maximum = x;

            //x += 0.1;

        }


    }
}
