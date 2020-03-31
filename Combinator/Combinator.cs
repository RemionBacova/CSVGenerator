using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCSV.Combinator
{
    class Combinator
    {

    

        private List<String> rowsToWrite = new List<string>();

        public void SetItemList (List<String> itemList)
        {
            List<String> Headers = new List<String>();
            List<List<String>> Values = new List<List<String>>();
            foreach (String i in itemList)
            {
                Headers.Add(i.Substring(0, i.IndexOf(',')));
                Values.Add(i.Substring(i.IndexOf(',') + 1).Split(',').Select(s => s).ToList());
            }

            List<String> randomListFromElements = new List<string>();

            int n = 100;
            string delemimiter = ",";

            foreach (int i in Enumerable.Range(1, n).ToList())
            {
                if (i == 1)
                {
                    rowsToWrite.Add(Headers.Aggregate((i, j) => i + delemimiter + j));
                }
                else
                {
                    randomListFromElements = new List<string>();
                    foreach (List<String> s in Values)
                    {
                        var random = new Random();
                        randomListFromElements.Add(s[random.Next(s.Count)]);
                    }
                    rowsToWrite.Add(randomListFromElements.Aggregate((i, j) => i + delemimiter + j));
                }
            }
        }

        public List<String> GetRowsToWrite()
        {
            return this.rowsToWrite;
        }
  
    }
}
