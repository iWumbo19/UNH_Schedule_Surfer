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
            Console.WriteLine("Parsing Data");
            string filePath = Path.Combine(Environment.CurrentDirectory, "schedule.xlsx");
            Excel.Application oExcel = new();
            Excel.Workbook WB = oExcel.Workbooks.Open(filePath);
            XLData.wks = (Excel.Worksheet)WB.Worksheets[1];
            XLData.xlRange = XLData.wks.UsedRange;
            XLData.rowCount = XLData.xlRange.Rows.Count;
            XLData.colCount = XLData.xlRange.Columns.Count;
            XLData.bldgCodes = XLData.GatherBldgCodes();
            Console.WriteLine("Building Codes Parsed!");
            Console.WriteLine($"Attempting to Parse {XLData.bldgCodes.Count} room codes");
            XLData.roomCodes = XLData.BuildRoomCodes();
            Console.WriteLine("Room Codes Parsed!");
            Console.WriteLine("Parsing Complete");

            Console.WriteLine("Ready for printing");
            Console.ReadLine();
            foreach (var item in XLData.roomCodes)
            {
                Console.Write(item + ", ");
            }


            Console.ReadLine();
        }

        
    }
}
