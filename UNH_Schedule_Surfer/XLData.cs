using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClosedXML.Excel;



namespace UNH_Schedule_Surfer
{
    static public class XLData
    {
        static public int rowCount;
        static public int colCount;
        static public List<string> bldgCodes;
        static public IXLWorksheet data;
        static public List<string> daysOfWeek = new()
        {
            {"M"},
            {"T"},
            {"W"},
            {"R"},
            {"F"},
            {"S"},
            {"U"},

        };


        static public List<string> GatherBldgCodes()
        {
            List<string> outputList = new();
            for (int row = 2; row < rowCount; row++)
            {
                var cell = data.Cell(row, 2).GetValue<string>();
                if (!outputList.Contains(cell)) { outputList.Add(cell); }
            }
            return outputList;
        }

        static public void PrintBldgCodes()
        {
            bldgCodes.ForEach(code => Console.Write(code + " "));
            Console.WriteLine("\n");
        }

        static public List<string> GatherRoomCodes(string bldg)
        {
            List<string> outputList = new();
            for (int row = 2; row < rowCount; row++)
            {
                var cell = data.Cell(row, 4).GetValue<string>();
                if (!outputList.Contains(cell) &&
                    data.Cell(row, 2).GetValue<string>() == bldg) 
                { outputList.Add(cell); }
            }
            return outputList;
        }

        static public void PrintRoomCodes(string currentBldg)
        {
            int bldgIndex = bldgCodes.IndexOf(currentBldg);
            GatherRoomCodes(bldgCodes[bldgIndex]).ForEach(item => Console.Write(item + " "));
        }

        static public List<string> GatherBeginTimes(string bldg, string room, string day)
        {
            List<string> outputList = new();
            for (int row = 2; row < rowCount; row++)
            {
                var cell = data.Cell(row, 6).GetValue<string>();
                if (!outputList.Contains(cell) &&
                    data.Cell(row, 2).GetValue<string>() == bldg &&
                    data.Cell(row, 4).GetValue<string>() == room &&
                    data.Cell(row, 5).GetValue<string>().Contains(day))
                { outputList.Add(cell); }
            }
            outputList = FormatTime(outputList);
            return outputList;
        }

        static public void PrintBeginTimes(string currentBldg, string currentRoom, string day)
        {
            int bldgIndex = bldgCodes.IndexOf(currentBldg);
            List<string> rooms = GatherRoomCodes(currentBldg);
            int roomIndex = rooms.IndexOf(currentRoom);
            GatherBeginTimes(bldgCodes[bldgIndex], rooms[roomIndex], day).ForEach(item => Console.Write(item + " "));



        }

        static public List<string> GatherEndTimes(string bldg, string room, string day)
        {
            List<string> outputList = new();
            for (int row = 2; row < rowCount; row++)
            {
                var cell = data.Cell(row, 7).GetValue<string>();
                if (!outputList.Contains(cell) &&
                    data.Cell(row, 2).GetValue<string>() == bldg &&
                    data.Cell(row, 4).GetValue<string>() == room &&
                    data.Cell(row, 5).GetValue<string>().Contains(day))
                { outputList.Add(cell); }
            }
            outputList = FormatTime(outputList);
            return outputList;
        }

        static public void PrintEndTimes(string currentBldg, string currentRoom, string day)
        {
            int bldgIndex = bldgCodes.IndexOf(currentBldg);
            List<string> rooms = GatherRoomCodes(currentBldg);
            int roomIndex = rooms.IndexOf(currentRoom);
            GatherEndTimes(bldgCodes[bldgIndex], rooms[roomIndex], day).ForEach(item => Console.Write(item + " "));
        }

        static public List<string> FormatTime(List<string> timeList)
        {
            List<string> outputList = new();
            char[] delimChars = { ' ', ':' };
            foreach (var item in timeList)
            {
                string nuItem;
                string[] split = item.Split(delimChars);
                if (split[2] == "PM")
                {
                    if (split[0] != "12")
                    {
                        int nuHour = int.Parse(split[0]);
                        nuHour += 12;
                        nuItem = nuHour + ":" + split[1];
                        outputList.Add(nuItem);
                    }
                    else
                    {
                        nuItem = split[0] + ":" + split[1];
                        outputList.Add(nuItem);
                    }
                }
                else
                {
                    nuItem = split[0] + ":" + split[1];
                    outputList.Add(nuItem);
                }
            }
            outputList.Sort();            
            return outputList;
        }

        static public void PrintFullTimes(List<string> beginTimes, List<string> endTimes, string bldg, string room)
        {
            Console.WriteLine($"Found Times for {bldg} {room}");
            for (int i = 0; i < beginTimes.Count; i++)
            {
                Console.WriteLine($"{beginTimes[i]}       {endTimes[i]}");
            }
            Console.WriteLine($"Current System Time: {DateTime.Now.ToString("HH:mm")}\n");            
        }
    }
}
