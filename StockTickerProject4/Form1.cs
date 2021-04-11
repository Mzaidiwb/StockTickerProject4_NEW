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

        public Form1()
        {
            InitializeComponent();
            chart1.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chart2.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chart3.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chart4.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chart5.ChartAreas[0].AxisY.IsStartedFromZero = false;
            chart6.ChartAreas[0].AxisY.IsStartedFromZero = false;



            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].CursorX.AutoScroll = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;

            chart2.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart2.ChartAreas[0].CursorX.AutoScroll = true;
            chart2.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;

            chart2.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart2.ChartAreas[0].CursorX.AutoScroll = true;
            chart2.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;

            chart3.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart3.ChartAreas[0].CursorX.AutoScroll = true;
            chart3.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;

            chart4.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart4.ChartAreas[0].CursorX.AutoScroll = true;
            chart4.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;

            chart5.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart5.ChartAreas[0].CursorX.AutoScroll = true;
            chart5.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;

            chart6.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart6.ChartAreas[0].CursorX.AutoScroll = true;
            chart6.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
        }


        public  void timer1_Tick(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].RecalculateAxesScale();
            chart2.ChartAreas[0].RecalculateAxesScale();
            chart3.ChartAreas[0].RecalculateAxesScale();
            chart4.ChartAreas[0].RecalculateAxesScale();
            chart5.ChartAreas[0].RecalculateAxesScale();
            chart6.ChartAreas[0].RecalculateAxesScale();
            //if (chart1.Series[0].Points.Count > 20)
            //{
            //    chart1.Series[0].Points.RemoveAt(0);
            //}

        }

        private async void GraphCharts()
        {
            List<string> MSFT2 = Program.CSV.MSFT_Dates(); //dates for all stocks (5 years from april 5 2021)

            //instantiate strings from ReadCSV class
            List<string> MSFT1 = Program.CSV.MSFT_Price();
            List<string> FB1 = Program.CSV.FB_Price();
            List<string> VOO1 = Program.CSV.VOO_Price();
            List<string> F1 = Program.CSV.F_Price();
            List<string> DIS1 = Program.CSV.DIS_Price();
            List<string> KO1 = Program.CSV.KO_Price();

            //Convert all to doubles
            List<double> MS_PRICE = MSFT1.Select(double.Parse).ToList();
            List<double> FB_Price = FB1.Select(double.Parse).ToList();
            List<double> VOO_Price = VOO1.Select(double.Parse).ToList();
            List<double> F_Price = F1.Select(double.Parse).ToList();
            List<double> DIS_Price = DIS1.Select(double.Parse).ToList();
            List<double> KO_Price = KO1.Select(double.Parse).ToList();

            for (int i = 0; i < MS_PRICE.Count; i++)
            {

                chart1.Series[0].Points.AddXY(MSFT2[i], MS_PRICE[i]);
                chart2.Series[0].Points.AddXY(MSFT2[i], FB_Price[i]);
                chart3.Series[0].Points.AddXY(MSFT2[i], VOO_Price[i]);
                chart4.Series[0].Points.AddXY(MSFT2[i], F_Price[i]);
                chart5.Series[0].Points.AddXY(MSFT2[i], DIS_Price[i]);
                chart6.Series[0].Points.AddXY(MSFT2[i], KO_Price[i]);

                await Task.Delay(100);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Tick += timer1_Tick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
            GraphCharts();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart1.Series.SuspendUpdates();
            chart2.Series.SuspendUpdates();
            chart3.Series.SuspendUpdates();
            chart4.Series.SuspendUpdates();
            chart5.Series.SuspendUpdates();
            chart6.Series.SuspendUpdates();
        }
    }
}
