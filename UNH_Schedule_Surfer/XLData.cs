using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace UNH_Schedule_Surfer
{
    static public class XLData
    {
        static public Excel.Worksheet wks;
        static public int rowCount;
        static public int colCount;
        static public Excel.Range xlRange;
        static public List<string> bldgCodes;
        static public List<List<string>> roomCodes;

        static public List<string> GatherBldgCodes()
        {
            List<string> bldgCodes = new List<string>();
            for (int i = 2; i < XLData.rowCount; i++)
            {
                string item = XLData.xlRange[2][i].Value;
                if (!bldgCodes.Contains(item)) { bldgCodes.Add(item); }
            }
            return bldgCodes;
        }

        static public List<string> GatherRoomCodes(string bldg)
        {
            List<string> roomCodes = new List<string>();
            for (int i = 2; i < XLData.rowCount; i++)
            {
                string item = XLData.xlRange[4][i].Value;
                if (XLData.xlRange[2][i].Value == bldg && !roomCodes.Contains(item)) { roomCodes.Add(item); }
            }
            return roomCodes;
        }

        static public List<string> GatherBeginTimes(string bldg, string room)
        {
            List<string> beginTimes = new List<string>();
            for (int i = 2; i < XLData.rowCount; i++)
            {
                string item = XLData.xlRange[6][i].Value;
                if (!beginTimes.Contains(item) &&
                    XLData.xlRange[4][i].Value == room &&
                    XLData.xlRange[2][i].Value == bldg)
                { beginTimes.Add(item); }
            }
            return beginTimes;
        }

        static public List<string> GatherEndTimes(string bldg, string room)
        {
            List<string> endTimes = new List<string>();
            for (int i = 2; i < XLData.rowCount; i++)
            {
                string item = XLData.xlRange[4][i].Value;
                if (!endTimes.Contains(item) &&
                    XLData.xlRange[4][i].Value == room &&
                    XLData.xlRange[2][i].Value == bldg)
                { endTimes.Add(item); }
            }
            return endTimes;
        }


        static public List<List<string>> BuildRoomCodes()
        {
            List<List<string>> outputList = new List<List<string>>();
            string currentBldg;
            List<string> currentRoomList = new List<string>();
            for (int _code = 0; _code < bldgCodes.Count(); _code++)
            {
                currentBldg = bldgCodes[_code];
                currentRoomList = null;
                currentRoomList = GatherRoomCodes(currentBldg);
                outputList.Add(currentRoomList);
                Console.WriteLine($"Compiled rooms for {currentBldg}");
            }
            return outputList;
        }



        //static public List<List<string>> BuildRoomCodes()
        //{
        //    List<List<string>> outputList;
        //    List<string> currentList;
        //    foreach (var item in bldgCodes)
        //    {
        //        currentList = null;
        //        for (int i = 2; i < XLData.rowCount; i++)
        //        {
        //            string room = XLData.xlRange[4][i].Value;
        //            if (XLData.xlRange[2][i].Value == item && !currentList.Contains(item)) { currentList.Add(room); }
        //        }
        //        outputList.Add(currentList);
        //    }
        //    return outputList;
        //}
    }
}
