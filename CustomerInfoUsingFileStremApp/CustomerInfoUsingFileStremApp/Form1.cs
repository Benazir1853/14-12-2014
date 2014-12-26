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

namespace CustomerInfoUsingFileStremApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string fileLocation = @"E:\Asp.net\Employee_Salarysheet.txt";
     

        private void saveButton_Click(object sender, EventArgs e)
        {
           string name = employeeIdTextBox.Text;
            string Id = employeeIdTextBox.Text;
            string salary = employeeSalaryTextBox.Text;
            FileStream aFileStream = new FileStream(fileLocation, FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(aFileStream);
            aStreamWriter.Write(name+ "," +Id+ "," +salary);
            aStreamWriter.WriteLine();
            aStreamWriter.Close();
            aFileStream.Close();
            

        }

        private void employeeNameTextBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            double sum = 0;
            FileStream aFileStream = new FileStream(fileLocation, FileMode.Open);
            StreamReader aStremReader = new StreamReader(aFileStream);
            employeeInfoListaBox.Items.Clear();
            while (!aStremReader.EndOfStream)
            {
                string x = aStremReader.ReadLine();
                employeeInfoListaBox.Items.Add(x);
                string[] Info = x.Split(',');
                sum += Convert.ToDouble(Info[2]);

            }
            totalAmountTextBox.Text = Convert.ToString(sum);
            aStremReader.Close();
            aFileStream.Close();
        }
    }
}
