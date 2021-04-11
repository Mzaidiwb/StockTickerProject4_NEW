using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

            
            chart1.Titles.Add("MSFT (Microsoft)");
            chart2.Titles.Add("FB (FaceBook)");
            chart3.Titles.Add("VOO (Vanguard S&P 500)");
            chart4.Titles.Add("F (Ford)");
            chart5.Titles.Add("DIS (Disney)");
            chart6.Titles.Add("KO (Coca Cola)");
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


        public void timer1_Tick(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].RecalculateAxesScale();
            chart2.ChartAreas[0].RecalculateAxesScale();
            chart3.ChartAreas[0].RecalculateAxesScale();
            chart4.ChartAreas[0].RecalculateAxesScale();
            chart5.ChartAreas[0].RecalculateAxesScale();
            chart6.ChartAreas[0].RecalculateAxesScale();
        }


        //private async void GraphCharts()
        //{
        //    List<string> MSFT2 = Program.CSV.MSFT_Dates(); //dates for all stocks (5 years from april 5 2021)

        //    //instantiate strings from ReadCSV class
        //    List<string> MSFT1 = Program.CSV.MSFT_Price();
        //    List<string> FB1 = Program.CSV.FB_Price();
        //    List<string> VOO1 = Program.CSV.VOO_Price();
        //    List<string> F1 = Program.CSV.F_Price();
        //    List<string> DIS1 = Program.CSV.DIS_Price();
        //    List<string> KO1 = Program.CSV.KO_Price();

        //    //Convert all to doubles
        //    List<double> MS_PRICE = MSFT1.Select(double.Parse).ToList();
        //    List<double> FB_Price = FB1.Select(double.Parse).ToList();
        //    List<double> VOO_Price = VOO1.Select(double.Parse).ToList();
        //    List<double> F_Price = F1.Select(double.Parse).ToList();
        //    List<double> DIS_Price = DIS1.Select(double.Parse).ToList();
        //    List<double> KO_Price = KO1.Select(double.Parse).ToList();

        //    for (int i = 0; i < MS_PRICE.Count; i++)
        //    {

        //        //chart1.Series[0].Points.AddXY(MSFT2[i], MS_PRICE[i]);
        //        //chart2.Series[0].Points.AddXY(MSFT2[i], FB_Price[i]);
        //        //chart3.Series[0].Points.AddXY(MSFT2[i], VOO_Price[i]);
        //        //chart4.Series[0].Points.AddXY(MSFT2[i], F_Price[i]);
        //        //chart5.Series[0].Points.AddXY(MSFT2[i], DIS_Price[i]);
        //        //chart6.Series[0].Points.AddXY(MSFT2[i], KO_Price[i]);

        //        await Task.Delay(100);
        //    }

        //}

        public void Graph_MSFT()
        {

            List<string> MSFT2 = Program.CSV.MSFT_Dates(); //dates for all stocks (5 years from april 5 2021)
            List<string> MSFT1 = Program.CSV.MSFT_Price();
            List<double> MS_PRICE = MSFT1.Select(double.Parse).ToList();
            Task.Run(() => chart1.Invoke((MethodInvoker)(async () =>
            {
                for (int i = 0; i < MS_PRICE.Count; i++)
                {
                    chart1.Series[0].Points.AddXY(MSFT2[i], MS_PRICE[i]);
                    await Task.Delay(1000);
                } 
            })));
        }

        public void Graph_FB()
        {
            List<string> MSFT2 = Program.CSV.MSFT_Dates(); //dates for all stocks (5 years from april 5 2021)
            List<string> FB1 = Program.CSV.FB_Price();
            List<double> FB_Price = FB1.Select(double.Parse).ToList();
            Task.Run(() => chart2.Invoke((MethodInvoker)(async () =>
            {
                for (int i = 0; i < FB_Price.Count; i++)
                {
                    chart2.Series[0].Points.AddXY(MSFT2[i], FB_Price[i]);
                    await Task.Delay(1000);
                }
            })));
        }

        public void Graph_VOO()
        {
            List<string> MSFT2 = Program.CSV.MSFT_Dates(); //dates for all stocks (5 years from april 5 2021)
            List<string> VOO1 = Program.CSV.VOO_Price();
            List<double> VOO_Price = VOO1.Select(double.Parse).ToList();
            Task.Run(() => chart3.Invoke((MethodInvoker)(async () =>
            {
                for (int i = 0; i < VOO_Price.Count; i++)
                {
                    chart3.Series[0].Points.AddXY(MSFT2[i], VOO_Price[i]);
                    await Task.Delay(1000);
                }
            })));
        }

        public void Graph_F()
        {
            List<string> MSFT2 = Program.CSV.MSFT_Dates(); //dates for all stocks (5 years from april 5 2021)
            List<string> F1 = Program.CSV.F_Price();
            List<double> F_Price = F1.Select(double.Parse).ToList();
            Task.Run(() => chart4.Invoke((MethodInvoker)(async () =>
            {
                for (int i = 0; i < F_Price.Count; i++)
                {
                    chart4.Series[0].Points.AddXY(MSFT2[i], F_Price[i]);
                    await Task.Delay(1000);
                }
            })));
        }

        public void Graph_DIS()
        {
            List<string> MSFT2 = Program.CSV.MSFT_Dates(); //dates for all stocks (5 years from april 5 2021)
            List<string> DIS1 = Program.CSV.DIS_Price();
            List<double> DIS_Price = DIS1.Select(double.Parse).ToList();
            Task.Run(() => chart5.Invoke((MethodInvoker)(async () =>
            {
                for (int i = 0; i < DIS_Price.Count; i++)
                {
                    chart5.Series[0].Points.AddXY(MSFT2[i], DIS_Price[i]);
                    await Task.Delay(1000);
                }
            })));
        }
        public void Graph_KO()
        {
            List<string> MSFT2 = Program.CSV.MSFT_Dates(); //dates for all stocks (5 years from april 5 2021)
            List<string> KO1 = Program.CSV.KO_Price();
            List<double> KO_Price = KO1.Select(double.Parse).ToList();
            Task.Run(() => chart6.Invoke((MethodInvoker)(async () =>
            {
                for (int i = 0; i < KO_Price.Count; i++)
                {
                    chart6.Series[0].Points.AddXY(MSFT2[i], KO_Price[i]);
                    await Task.Delay(1000);
                }
            })));
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Thread MSFT = new Thread(Graph_MSFT);
            Thread FB = new Thread(Graph_FB);
            Thread VOO = new Thread(Graph_VOO);
            Thread F = new Thread(Graph_F);
            Thread DIS = new Thread(Graph_DIS);
            Thread KO = new Thread(Graph_KO);

            MSFT.Start();
            FB.Start();
            VOO.Start();
            F.Start();
            DIS.Start();
            KO.Start();

            timer1.Start();
            timer1.Interval = 2000;
            
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
