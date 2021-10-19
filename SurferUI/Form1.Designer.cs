
namespace SurferUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BuildingPicker = new System.Windows.Forms.ComboBox();
            this.OutputWindow = new System.Windows.Forms.RichTextBox();
            this.RoomPicker = new System.Windows.Forms.ComboBox();
            this.DayPicker = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ClipboardButton = new System.Windows.Forms.Button();
            this.FilePathBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ProfessorPicker = new System.Windows.Forms.ComboBox();
            this.ProfessorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BuildingPicker
            // 
            this.BuildingPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuildingPicker.FormattingEnabled = true;
            this.BuildingPicker.Location = new System.Drawing.Point(12, 73);
            this.BuildingPicker.Name = "BuildingPicker";
            this.BuildingPicker.Size = new System.Drawing.Size(135, 23);
            this.BuildingPicker.TabIndex = 0;
            this.BuildingPicker.SelectedIndexChanged += new System.EventHandler(this.BuildingPicker_SelectedIndexChanged);
            // 
            // OutputWindow
            // 
            this.OutputWindow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputWindow.Location = new System.Drawing.Point(12, 162);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.Size = new System.Drawing.Size(507, 371);
            this.OutputWindow.TabIndex = 1;
            this.OutputWindow.Text = "";
            this.OutputWindow.TextChanged += new System.EventHandler(this.OutputWindow_TextChanged);
            // 
            // RoomPicker
            // 
            this.RoomPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomPicker.FormattingEnabled = true;
            this.RoomPicker.Location = new System.Drawing.Point(153, 73);
            this.RoomPicker.Name = "RoomPicker";
            this.RoomPicker.Size = new System.Drawing.Size(135, 23);
            this.RoomPicker.TabIndex = 2;
            this.RoomPicker.SelectedIndexChanged += new System.EventHandler(this.RoomPicker_SelectedIndexChanged);
            // 
            // DayPicker
            // 
            this.DayPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayPicker.FormattingEnabled = true;
            this.DayPicker.Location = new System.Drawing.Point(294, 73);
            this.DayPicker.Name = "DayPicker";
            this.DayPicker.Size = new System.Drawing.Size(135, 23);
            this.DayPicker.TabIndex = 3;
            this.DayPicker.SelectedIndexChanged += new System.EventHandler(this.DayPicker_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(435, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ClipboardButton
            // 
            this.ClipboardButton.Location = new System.Drawing.Point(179, 539);
            this.ClipboardButton.Name = "ClipboardButton";
            this.ClipboardButton.Size = new System.Drawing.Size(173, 23);
            this.ClipboardButton.TabIndex = 5;
            this.ClipboardButton.Text = "Copy Times To Clipboard";
            this.ClipboardButton.UseVisualStyleBackColor = true;
            this.ClipboardButton.Click += new System.EventHandler(this.ClipboardButton_Click);
            // 
            // FilePathBox
            // 
            this.FilePathBox.Location = new System.Drawing.Point(12, 27);
            this.FilePathBox.Name = "FilePathBox";
            this.FilePathBox.Size = new System.Drawing.Size(417, 23);
            this.FilePathBox.TabIndex = 6;
            this.FilePathBox.TextChanged += new System.EventHandler(this.FilePathBox_TextChanged);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(435, 25);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(83, 23);
            this.BrowseButton.TabIndex = 7;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // ProfessorPicker
            // 
            this.ProfessorPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProfessorPicker.FormattingEnabled = true;
            this.ProfessorPicker.Location = new System.Drawing.Point(12, 123);
            this.ProfessorPicker.Name = "ProfessorPicker";
            this.ProfessorPicker.Size = new System.Drawing.Size(276, 23);
            this.ProfessorPicker.TabIndex = 8;
            this.ProfessorPicker.SelectedIndexChanged += new System.EventHandler(this.ProfessorPicker_SelectedIndexChanged);
            // 
            // ProfessorButton
            // 
            this.ProfessorButton.Location = new System.Drawing.Point(435, 123);
            this.ProfessorButton.Name = "ProfessorButton";
            this.ProfessorButton.Size = new System.Drawing.Size(84, 23);
            this.ProfessorButton.TabIndex = 9;
            this.ProfessorButton.Text = "Search";
            this.ProfessorButton.UseVisualStyleBackColor = true;
            this.ProfessorButton.Click += new System.EventHandler(this.ProfessorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current Spreadsheet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Building";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Professors";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 574);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProfessorButton);
            this.Controls.Add(this.ProfessorPicker);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.FilePathBox);
            this.Controls.Add(this.ClipboardButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DayPicker);
            this.Controls.Add(this.RoomPicker);
            this.Controls.Add(this.OutputWindow);
            this.Controls.Add(this.BuildingPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "UNH Schedule Surfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BuildingPicker;
        private System.Windows.Forms.RichTextBox OutputWindow;
        private System.Windows.Forms.ComboBox RoomPicker;
        private System.Windows.Forms.ComboBox DayPicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ClipboardButton;
        private System.Windows.Forms.TextBox FilePathBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.ComboBox ProfessorPicker;
        private System.Windows.Forms.Button ProfessorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

