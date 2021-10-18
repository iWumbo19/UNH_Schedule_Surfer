using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurferUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BuildingPicker.DataSource = XLData.bldgCodes;
            DayPicker.DataSource = XLData.daysOfWeek;
            FilePathBox.Text = XLData.filePath;
        }

        private void BuildingPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomPicker.DataSource = XLData.GatherRoomCodes(BuildingPicker.Text);
        }

        private void OutputWindow_TextChanged(object sender, EventArgs e)
        {

        }

        private void DayPicker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            OutputWindow.Text = XLData.ReturnFullTimes(XLData.GatherBeginTimes(BuildingPicker.Text, RoomPicker.Text, DayPicker.Text), 
                XLData.GatherEndTimes(BuildingPicker.Text, RoomPicker.Text, DayPicker.Text), BuildingPicker.Text, RoomPicker.Text);
        }

        private void RoomPicker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(XLData.ReturnClipboardTimes(XLData.GatherBeginTimes(BuildingPicker.Text, RoomPicker.Text, DayPicker.Text),
                XLData.GatherEndTimes(BuildingPicker.Text, RoomPicker.Text, DayPicker.Text), BuildingPicker.Text, RoomPicker.Text, DayPicker.Text));
        }

        private void FilePathBox_TextChanged(object sender, EventArgs e)
        {
            XLData.filePath = FilePathBox.Text;
            //XLData.ChangeSpreadSheet();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse For Schedule Excel Sheet",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xlsx",
                Filter = "xlsx files (*.xlsx)|*.xlsx",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePathBox.Text = openFileDialog1.FileName;
            }
        }
    }
}
