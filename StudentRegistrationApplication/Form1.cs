using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string month = comboBox1.GetItemText(comboBox1.SelectedItem);
            string day = comboBox2.GetItemText(comboBox2.SelectedItem);
            string year = comboBox3.GetItemText(comboBox3.SelectedItem);
            string gender = radioButton1.Checked == true ? "Male" : "Female";

            string lastname, firstname, middlename, program;

            lastname = lname.Text;
            firstname = fname.Text;
            middlename = mname.Text;
            program = comboBox4.Text;

            DisplayStudentInformation(firstname, middlename, lastname, gender, $"{day}/{month}/{year}", program);

            DisplayStudentInformation(firstname, lastname, program);

            DisplayStudentInformation(firstname, lastname, program);


        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 31; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            for (int i = 1; i < 12; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }
            for (int i = 1900; i < 2024; i++)
            {
                comboBox3.Items.Add(i.ToString());

                ArrayList prgramlist = new ArrayList();
                prgramlist.Add("Bachelor of Science in Information Technology");
                prgramlist.Add("Bachelor of Science in Information System");
                prgramlist.Add("Bachelor of Science in Computer Science");
                prgramlist.Add("Bachelor of Science in Computer Engineering");
                comboBox4.Items.AddRange(prgramlist.ToArray());

                foreach (string program in prgramlist)
                {
                    Console.WriteLine(program);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void DisplayStudentInformation(string firstName, string middleName, string lastName, string gender, string dob, string program)
        {
            MessageBox.Show($"Student name: {firstName} {middleName} {lastName}\nGender: {gender}\nDate of Birth: {dob}\nProgram: {program}");
        }


        private void DisplayStudentInformation(string firstName, string middleName, string lastName, string program)
        {
            MessageBox.Show($"Student name: {firstName} {middleName} {lastName}\nProgram: {program}");
        }

        private void DisplayStudentInformation(string firstName, string lastName, string program)
        {
            MessageBox.Show($"Student name: {firstName} {lastName} \nProgram: {program}");
        }
    }
}
    
