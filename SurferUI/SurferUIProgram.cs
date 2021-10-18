using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurferUI
{
    static class SurferUIProgram
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Opens Spreadsheet
            XLData.filePath = Path.Combine(Environment.CurrentDirectory, "schedule.xlsx");
            using var wbook = new XLWorkbook(XLData.filePath);
            //Gives XLData the correct worksheet
            XLData.data = wbook.Worksheet(1);

            //Uses data variable to fill in sheet parameters and variables
            XLData.rowCount = XLData.data.LastRowUsed().RowNumber();
            XLData.colCount = XLData.data.LastColumnUsed().ColumnNumber();
            XLData.bldgCodes = XLData.GatherBldgCodes();


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());       

        }

        
    }
}
