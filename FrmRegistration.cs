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

namespace CreatingTextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getInput = txtStudentNo.Text;
            string getInput1 = txtLastName.Text;
            string getInput2 = txtAge.Text;
            string getInput3 = DatePicker.Text;
            string getInput4 = cbProgram.Text;
            string getInput5 = txtFirstName.Text;
            string getInput6 = txtMI.Text;
            string getInput7 = txtGender.Text;
            string getInput8 = txtContact.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, getInput + ".txt")))
            {
                outputFile.WriteLine("Student No:" + getInput);
                Console.WriteLine(getInput);
                outputFile.WriteLine("Last Name:" + getInput1);
                Console.WriteLine(getInput1);
                outputFile.WriteLine("Age:" + getInput2);
                Console.WriteLine(getInput2);
                outputFile.WriteLine("Birthday:" + getInput3);
                Console.WriteLine(getInput3);
                outputFile.WriteLine("Program:" + getInput4);
                Console.WriteLine(getInput4);
                outputFile.WriteLine("First Name:" + getInput5);
                Console.WriteLine(getInput5);
                outputFile.WriteLine("Middle Initial:" + getInput6);
                Console.WriteLine(getInput6);
                outputFile.WriteLine("Gender:" + getInput7);
                Console.WriteLine(getInput7);
                outputFile.WriteLine("Contact No:" + getInput8);
                Console.WriteLine(getInput8);

                Close();
            }
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
        }
    }
}
