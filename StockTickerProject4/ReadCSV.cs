using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StockTickerProject4
{
    public class ReadCSV
    {
        public List<string> MSFT_Price()
        {
            
            using (var reader = new StreamReader(@"C:\Users\Mohammad\Downloads\Stocks\MSFT.csv"))
            {
                reader.ReadLine();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    listB.Add(values[1]); //stock open
                    

                }
                
                return listB;
            }
        }
        public List<string> FB_Price()
        {
            //FB
            using (var reader = new StreamReader(@"C:\Users\Mohammad\Downloads\Stocks\FB.csv"))
            {
                reader.ReadLine();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    listB.Add(values[1]); //stock open


                }

                return listB;
            }
        }

        public List<string> VOO_Price()
        {
            //VOO
            using (var reader = new StreamReader(@"C:\Users\Mohammad\Downloads\Stocks\VOO.csv"))
            {
                reader.ReadLine();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    listB.Add(values[1]); //stock open


                }

                return listB;
            }
        }

        public List<string> F_Price()
        {
            //Ford
            using (var reader = new StreamReader(@"C:\Users\Mohammad\Downloads\Stocks\F.csv"))
            {
                reader.ReadLine();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    listB.Add(values[1]); //stock open


                }

                return listB;
            }
        }

        public List<string> DIS_Price()
        {
            //Disney
            using (var reader = new StreamReader(@"C:\Users\Mohammad\Downloads\Stocks\DIS.csv"))
            {
                reader.ReadLine();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    listB.Add(values[1]); //stock open


                }

                return listB;
            }
        }

        public List<string> KO_Price()
        {
            //Coke
            using (var reader = new StreamReader(@"C:\Users\Mohammad\Downloads\Stocks\KO.csv"))
            {
                reader.ReadLine();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    listB.Add(values[1]); //stock open


                }

                return listB;
            }
        }
        public List<String> Stock_Dates() //This is only reading MSFT dates which will be the same for all stocks
                                         //No need to add date reading for other stocks
        {
            using (var reader = new StreamReader(@"C:\Users\Mohammad\Downloads\Stocks\MSFT.csv"))
            {
                reader.ReadLine();
                List<string> listA = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    listA.Add(values[0]); //dates


                }
                return listA;
            }
        }

    }
}
