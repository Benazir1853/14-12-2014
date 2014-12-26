using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVLib;

namespace CustomerRegApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private string path = @"H:\studentRecord.csv";


        private void saveButton_Click(object sender, EventArgs e)
        {
            string regNo = regNoTextbox.Text;
            string name = nameTextBox.Text;

            if (File.Exists(path))
            {

                bool uniqueReg = UniqueRegNoCheker(regNo);

                if (uniqueReg == true)
                {
                    FileStream aFileStream = new FileStream(path, FileMode.Append);
                    CsvFileWriter aWriter = new CsvFileWriter(aFileStream);
                    List<string> aStudentRecord = new List<string>();
                    aStudentRecord.Add(regNo);
                    aStudentRecord.Add(name);
                    aWriter.WriteRow(aStudentRecord);
                    aFileStream.Close();
                }
                else
                {
                    MessageBox.Show("Please, Provide another registration number");
                }
            }
            else
            {
                FileStream aFileStream = new FileStream(path, FileMode.Append);
                CsvFileWriter aWriter = new CsvFileWriter(aFileStream);
                List<string> aStudentRecord = new List<string>();
                aStudentRecord.Add(regNo);
                aStudentRecord.Add(name);
                aWriter.WriteRow(aStudentRecord);
                aFileStream.Close();
            }
        }
        private bool UniqueRegNoCheker(string studentReg)
        {
            int studentRegInt = Convert.ToInt32(studentReg);
            FileStream aFileStream = new FileStream(path, FileMode.Open);
            CsvFileReader aCsvFileReader = new CsvFileReader(aFileStream);
            List<string> aStudentDataRead = new List<string>();
            showAllListBox.Items.Clear();
            bool a = true;
            while (aCsvFileReader.ReadRow(aStudentDataRead))
            {
                int studentRegNo = Convert.ToInt32(aStudentDataRead[0]);
                if (studentRegInt == studentRegNo)
                {
                    a = false;
                    break;
                }
                else
                {
                    a = true;
                }
            }
            aFileStream.Close();
            return a;
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(path, FileMode.Open);
            CsvFileReader aCsvFileReader = new CsvFileReader(aFileStream);
            List<string> aStudentDataRead = new List<string>();
            showAllListBox.Items.Clear();
            while (aCsvFileReader.ReadRow(aStudentDataRead))
            {
                string studentRegNo = aStudentDataRead[0];
                string studentName = aStudentDataRead[1];
                showAllListBox.Items.Add(studentRegNo + " " + studentName);
            }
            aFileStream.Close();
        }

    }
}
