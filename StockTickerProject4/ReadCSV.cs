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
        public List<String> MSFT_Price()
        {
            using (var reader = new StreamReader(@"C:\Users\Mohammad\Downloads\MSFT.csv"))
            {
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
        public List<String> MSFT_Dates()
        {
            using (var reader = new StreamReader(@"C:\Users\Mohammad\Downloads\MSFT.csv"))
            {
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
