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

namespace PersonalInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string path = @"E:\personalRecord.csv";
        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string pContact = personalContactTextBox.Text;
            string hContact = homeContactTextBox.Text;
            string hAddress = homeAddressTextBox.Text;
            if (File.Exists(path))
            {

                bool uniqueCon = UniqueContactNoCheker(pContact);

                if (uniqueCon == true)
                {
                    FileStream aFileStream = new FileStream(path, FileMode.Append);
                    CsvFileWriter aWriter = new CsvFileWriter(aFileStream);
                    List<string> aStudentRecord = new List<string>();
                    aStudentRecord.Add(pContact);
                    aStudentRecord.Add(name);
                    aWriter.WriteRow(aStudentRecord);
                    aFileStream.Close();
                }
                else
                {
                    MessageBox.Show("Please, Provide another Personal Contact number");
                }
            }
            else
            {
                FileStream aFileStream = new FileStream(path, FileMode.Append);
                CsvFileWriter aWriter = new CsvFileWriter(aFileStream);
                List<string> aStudentRecord = new List<string>();
                aStudentRecord.Add(pContact);
                aStudentRecord.Add(name);
                aWriter.WriteRow(aStudentRecord);
                aFileStream.Close();
            }
        }
        private bool UniqueContactNoCheker(string studentReg)
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
            CsvFileReader aCsvFileReader= new CsvFileReader(aFileStream);
            List<String> aPersonList = new List<string>();
            showAllListBox.Items.Clear();
            while (aCsvFileReader.ReadRow(aPersonList))
            {
                string name = aPersonList[0];
                string email = aPersonList[1];
                string pContact = aPersonList[2];
                string hContact = aPersonList[3];
                string hAddress = aPersonList[4];
                showAllListBox.Items.Add(name+ "" +email+ "" +pContact+ "" +hContact+ "" +hAddress);
            }
        }

    }
}
