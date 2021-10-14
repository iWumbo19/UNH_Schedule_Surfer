using System;
using System.IO;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace UNH_Schedule_Surfer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializes Excel Sheet and sets "Summary" Tab to 'wks'
            string filePath = Path.Combine(Environment.CurrentDirectory, "schedule.xlsx");
            Excel.Application oExcel = new();
            Excel.Workbook WB = oExcel.Workbooks.Open(filePath);
            Excel.Worksheet wks = (Excel.Worksheet)WB.Worksheets[1];
            Excel.Range xlRange = wks.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            Console.WriteLine($"{rowCount} by {colCount} grid");


            Console.WriteLine(xlRange[6][5].Value);





            Console.ReadLine();


        }
    }
}
