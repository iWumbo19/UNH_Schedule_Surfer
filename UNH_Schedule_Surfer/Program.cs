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


            List<string> bldgCodes = GatherBldgCodes(rowCount, xlRange);
            foreach (var item in bldgCodes)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
            List<string> roomCodes = GatherRoomCodes(rowCount, xlRange, bldgCodes[3]);
            foreach (var item in roomCodes)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
            List<string> beginTimes = GatherBeginTimes(rowCount, xlRange, bldgCodes[3], roomCodes[3]);
            foreach (var item in beginTimes)
            {
                Console.Write($"{item}, ");
            }


            Console.ReadLine();
        }

        static List<string> GatherBldgCodes(int rowCount, dynamic xlRange)
        {
            List<string> bldgCodes = new List<string>();
            for (int i = 2; i < rowCount; i++)
            {
                string item = xlRange[2][i].Value;
                if (!bldgCodes.Contains(item)) { bldgCodes.Add(item); }
            }
            return bldgCodes;
        }

        static List<string> GatherRoomCodes(int rowCount, dynamic xlRange, string bldg)
        {
            List<string> roomCodes = new List<string>();
            for (int i = 2; i < rowCount; i++)
            {
                string item = xlRange[4][i].Value;
                if (!roomCodes.Contains(item) && xlRange[2][i].Value == bldg) { roomCodes.Add(item); }
            }
            return roomCodes;
        }

        static List<string> GatherBeginTimes(int rowCount, dynamic xlRange, string bldg, string room)
        {
            List<string> beginTimes = new List<string>();
            for (int i = 2; i < rowCount; i++)
            {
                string item = xlRange[6][i].Value;
                if (!beginTimes.Contains(item) && 
                    xlRange[4][i].Value == room && 
                    xlRange[2][i].Value == bldg) 
                { beginTimes.Add(item); }
            }
            return beginTimes;
        }

        static List<string> GatherEndTimes(int rowCount, dynamic xlRange,string bldg, string room)
        {
            List<string> endTimes = new List<string>();
            for (int i = 2; i < rowCount; i++)
            {
                string item = xlRange[4][i].Value;
                if (!endTimes.Contains(item) && 
                    xlRange[4][i].Value == room && 
                    xlRange[2][i].Value == bldg) 
                { endTimes.Add(item); }
            }
            return endTimes;
        }
    }
}
