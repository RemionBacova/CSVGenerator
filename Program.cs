using System;
using System.Collections.Generic;
using System.Linq;
using TestCSV.Model.CSV;
using TestCSV.Combinator;

namespace TestCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader a = new Reader();
            TestCSV.Combinator.Combinator b = new TestCSV.Combinator.Combinator();
            Writer c = new Writer();

            a.readFromFile();
            b.SetItemList(a.GetRows());
      
            c.SetRows(b.GetRowsToWrite());
            c.writeToFile();




            foreach(String s in b.GetRowsToWrite())
            {
                
                Console.WriteLine(s);
            }

        }
    }
}
