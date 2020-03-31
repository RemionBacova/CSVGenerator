using System;
using System.Collections.Generic;
using System.IO;

namespace TestCSV.Model.CSV
{
    class Writer
    {
        private  List<String> itemList = new List<String>();
        public  void writeToFile()
        {
            using (StreamWriter z = new StreamWriter("C:\\Documents\\test.csv"))
            {

                foreach (string item in itemList)
                {
                    z.WriteLine(item);
                }
            }
        }

        public void SetRows(List<String> itemList)
        {
            this.itemList = itemList;
            
        }
    }
}
