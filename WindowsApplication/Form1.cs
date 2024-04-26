using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class StudentRegistration : Form
    {
        public static string gender;
        private int date;
        public StudentRegistration()
        {

            InitializeComponent();

            string[] months = new string[]
            {
              "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
            };

            ArrayList course = new ArrayList();
            course.Add("Bachelor of Science in Computer Science");
            course.Add("Bachelor of Science in Information Technology");
            course.Add("Bachelor of Science in Information System");
            course.Add("Bachelor of Science in Computer Engineering");

            foreach (string program in course)
            {
                comboBox1Program.Items.Add(program);
            }

            for (int i = 1900; i < DateTime.Today.Year; i++)
            {
                comboBox3Year.Items.Add(i);
            }
            for (int i = 1; i <= 31; i++)
            {
                comboBox1Day.Items.Add(i);

            }

            foreach (string month in months)
            {
                comboBox2Month.Items.Add(month);


            }

            {

            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastName = textBox3LastName.Text;
            string firstName = textBox1FirstName.Text;
            string middleName = textBox2MiddleName.Text;
            string program = comboBox1Program.Text;
            string day = comboBox1Day.Text;
            string month = comboBox2Month.Text;
            string year = comboBox3Year.Text;
            if (radioButton1Male.Checked)
            {
                gender = "Male";
            }
            else if (radioButton2Female.Checked)
            {
                gender = "Female";
            }

            Console.WriteLine(lastName);
            Console.WriteLine(firstName);
            Console.WriteLine(middleName);
            Console.WriteLine(program);


            /*MessageBox.Show($"Student name: {firstName+" "+middleName+ " " +lastName}\n" +
                $"Gender: {gender}\n" +
                $"Date of Birth: {comboBox1Day.Text +"/"+comboBox2Month.Text+"/"+ comboBox3Year.Text}\n" +
                $"Program: {comboBox1Program.Text}");
            */
            if (comboBox1Day.Equals("Day") && comboBox3Year.Equals("Year") && comboBox2Month.Equals("Month"))
            {
                if (!radioButton1Male.Checked && !radioButton2Female.Checked)
                {
                   
                }
            } else if (comboBox1Day.Equals("Day") && comboBox3Year.Equals("Year") && comboBox2Month.Equals("Month"))
            {
                firstMessage(firstName, lastName,middleName, program, gender);
            }
            else
            {
                firstMessage(firstName, lastName, middleName, program);
            }

        }

        private void textBox3LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1Day_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2Month_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void radioButton1Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
       
        public  void firstMessage(string firstName, string lastName, string middleName, string program) 
        {

            MessageBox.Show("Student Name:" + firstName +" " + " " + lastName + "\n " +
                "Program: " + program); 
        }
        public void firstMessage(string firstName, string lastName, string middleName, string program,string gender)
        {

            MessageBox.Show($"Student name: {firstName + " " + middleName + " " + lastName}\n" +
               $"Gender: {gender} \n"+
               $"Program: {program}") ;
        }
        public void firstMessage(string firstName, string lastName, string middleName, string program, string gender,string day, string month, string year)
        {
           
            MessageBox.Show($"Student name: {firstName + " " + middleName + " " + lastName}\n" +
                $"Gender: {gender}\n" +
               $"Month{month +" "+ day +" "+ year}\n"+
               $"Program: {program}");
        }

    }
}
