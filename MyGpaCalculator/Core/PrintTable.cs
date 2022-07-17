using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGpaCalculator.Core
{
    public class PrintTable
    {
        private string[] Titles;
        private List<int> TitleLengths;
        private List<string[]> rows = new List<string[]>();

        public PrintTable(string title1, string title2, string title3, string title4, string title5, string title6, string title7)
        {
            string[] titles = new string[]
            {
            title1, title2, title3, title4, title5, title6, title7
            };
            Titles = titles;

            List<int> lengths = new List<int>();
            {
                lengths.Add(title1.Length);
                lengths.Add(title2.Length);
                lengths.Add(title3.Length);
                lengths.Add(title4.Length);
                lengths.Add(title5.Length);
                lengths.Add(title6.Length);
                lengths.Add(title7.Length);
            };


            TitleLengths = lengths;

        }

        public void RowAdd_Check_add(params object[] ndRows)
        {
            //fill up each row of string array, collecting data from calcualtion class  
            rows.Add(ndRows.Select(x => x.ToString()).ToArray());

            //checking if the length of the iputed subject, score
            //remark etc, and update the length 
            for (int i = 0; i < Titles.Length; i++)
            {
                if (rows.Last()[i].Length > TitleLengths[i])
                {
                    TitleLengths[i] = rows.Last()[i].Length;
                }
            }
        }
        public void TablePrinter()
        {
            //methode to print the header, and rows.
            TitleLengths.ForEach(len => Console.Write("*-" + new string('-', len) + "-"));
            Console.WriteLine('*');

            string TitlePrint = "";
            for (int i = 0; i < Titles.Length; i++)
            {
                TitlePrint += "| " + Titles[i].PadRight(TitleLengths[i]) + ' ';
            }
            Console.WriteLine(TitlePrint + "|");
            TitleLengths.ForEach(len => Console.Write("*-" + new string('-', len) + "-"));
            Console.WriteLine('*');

            foreach (var row in rows)
            {
                string rowPrint = "";
                for (int i = 0; i < row.Length; i++)
                {
                    rowPrint += "| " + row[i].PadRight(TitleLengths[i]) + ' ';
                }
                Console.WriteLine(rowPrint + "|");
            } 

            TitleLengths.ForEach(len => Console.Write("*-" + new string('-', len) + "-"));
            Console.WriteLine('*');
        }
    }
}