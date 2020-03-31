using System;
using System.Collections.Generic;
using System.Linq;

namespace TestCSV.Model.CSV
{
    class Reader
    {
        private List<String> itemlist = new List<String>();
        public void readFromFile()
        {
            var lines = System.IO.File.ReadAllLines("C:\\Documents\\Struktura.csv").TakeWhile(t => t != null);

            foreach (string item in lines)
            {
                itemlist.Add(item);
            }
        }

        public List<String> GetRows()
        {
            return itemlist;

        }
    }
}
