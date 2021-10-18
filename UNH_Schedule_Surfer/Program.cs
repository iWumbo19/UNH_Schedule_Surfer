using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using ClosedXML.Excel;

namespace UNH_Schedule_Surfer
{
    class Program
    {        
        static void Main(string[] args)
        {
            Program pgm = new();
            
            Console.WriteLine("Opening Spreadsheet");
            //Opens Spreadsheet
            string filePath = Path.Combine(Environment.CurrentDirectory, "schedule.xlsx");
            using var wbook = new XLWorkbook(filePath);
            //Gives XLData the correct worksheet
            XLData.data = wbook.Worksheet(1);

            Console.WriteLine("Assigning data values");
            //Uses data variable to fill in sheet parameters and variables
            XLData.rowCount = XLData.data.LastRowUsed().RowNumber();
            XLData.colCount = XLData.data.LastColumnUsed().ColumnNumber();
            XLData.bldgCodes = XLData.GatherBldgCodes();
            Console.WriteLine("Parsing Succesful");

            
            
            
            //Begin Console Program
            pgm.TopOfLoop();

        }

        public void TopOfLoop()
        {
            string bldgAsk;
            Console.WriteLine("What building would you like to lookup:");
            bldgAsk = Console.ReadLine().ToUpper();
            if (bldgAsk == "HELP") { XLData.PrintBldgCodes(); TopOfLoop(); }
            else if (!XLData.bldgCodes.Contains(bldgAsk)) { Console.WriteLine("Building not recognized. Type \"help\" for building codes"); TopOfLoop(); }
            List<string> currentBldgRooms = XLData.GatherRoomCodes(bldgAsk);
            Console.WriteLine("What room do you wish to lookup:");
            currentBldgRooms.ForEach(item => Console.Write(item + " "));
            Console.WriteLine("\n");
            string roomAsk = Console.ReadLine().ToUpper();
            if (!currentBldgRooms.Contains(roomAsk)) { Console.WriteLine("Room not recognized. Try again"); TopOfLoop(); }
            Console.WriteLine("What day of the week is it(M, T, W, R, F, S, U):");
            string dayAsk = Console.ReadLine().ToUpper();
            if(!XLData.daysOfWeek.Contains(dayAsk)) { Console.WriteLine("That is not a valid day. Please use the following M, T, W, R, F, S, U"); TopOfLoop(); }
            XLData.PrintFullTimes(XLData.GatherBeginTimes(bldgAsk, roomAsk, dayAsk), XLData.GatherEndTimes(bldgAsk, roomAsk, dayAsk), bldgAsk, roomAsk);
            TopOfLoop();
        }


    }
}
