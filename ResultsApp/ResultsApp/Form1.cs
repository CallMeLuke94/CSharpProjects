using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultsApp
{
    public partial class Form1 : Form
    {
        public List<Student> students = new List<Student>();
        private int currentStudent = 0;
        public bool addFormAvailable = true;
        public bool searchFormAvailable = true;

        public Form1()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            students.Add(new Student(1, "Alice", 1, 'B', 102, 91, 145));
            students.Add(new Student(2, "Bill", 2, 'C', 100, 77, 105));
            students.Add(new Student(3, "Charlie", 3, 'B', 0, 1, 2));
            students.Add(new Student(4, "Dan", 2, 'C', 40, 55, 120));

            display(currentStudent);
        }

        public void display(int n)
        {
            if (n < 0)
                n = 0;
            if (n > students.Count() - 1)
                n = students.Count() - 1;

            int totalMarks = students[n].subject1Score + students[n].subject2Score + students[n].subject3Score;
            TextBox[] markBoxes = { this.textBox3, this.textBox4, this.textBox5 };
            int[] rawMarks = { students[n].subject1Score, students[n].subject2Score, students[n].subject3Score };
            double[] percents = { subPerc(students[n].subject1Score), subPerc(students[n].subject2Score), subPerc(students[n].subject3Score) };
            int fails = 0;

            for (int i = 0; i < 3; i++)
            {
                markBoxes[i].BackColor = SystemColors.Control;
                if (rawMarks[i] < 90)
                {
                    markBoxes[i].ForeColor = Color.Red;
                    fails++;
                }
                else
                {
                    markBoxes[i].ForeColor = SystemColors.WindowText;
                }

                markBoxes[i].Text = rawMarks[i].ToString();
            }

            if (fails > 0)
            {
                this.panel1.Visible = false;
                this.panel2.Visible = true;
            }
            else
            {
                this.panel2.Visible = false;
                this.panel1.Visible = true;
            }

            this.textBox1.Text = students[n].registrationNumber.ToString();
            this.textBox2.Text = students[n].studentName;
            this.textBox6.Text = (totalMarks).ToString();
            this.textBox9.Text = students[n].classNumber.ToString();
            if (students[n].groupCode == 'B')
                this.textBox10.Text = "Business";
            else if (students[n].groupCode == 'C')
                this.textBox10.Text = "Computing";
            else
                this.textBox10.Text = "Unknown Group";

            int totalPerc = (int) Math.Round(totalPer(totalMarks));
            this.textBox7.Text = totalPerc.ToString();

            string grade = "";
            if (totalPerc < 60)
                grade = "fail";
            else if (totalPerc < 70)
                grade = "C";
            else if (totalPerc < 80)
                grade = "B";
            else if (totalPerc < 90)
                grade = "A";
            else
                grade = "A+";

            this.textBox8.Text = grade;

            switch (fails){
                case 0:
                    this.panel2.Visible = false;
                    break;
                case 1:
                    this.label1.Text = "Retake Exam";
                    break;
                case 2:
                    this.label1.Text = "Repeat Course";
                    break;
                case 3:
                    this.label1.Text = "Fail: Drop Out";
                    break;
            }

            if (n == 0)
            {
                if (students.Count() == 1)
                    this.button1.Enabled = false;
                else
                    this.button1.Enabled = true;
                this.button2.Enabled = false;
            }
            else if (n == students.Count() - 1)
            {
                this.button1.Enabled = false;
                this.button2.Enabled = true;
            }
            else
            {
                this.button2.Enabled = true;
                this.button1.Enabled = true;
            }

            this.button4.Enabled = true;
            this.button5.Enabled = true;
            this.button7.Enabled = true;
        }

        private double subPerc(double score)
        {
            return (score / 150) * 100;
        }

        private double totalPer(double total)
        {
            return (total / 450) * 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentStudent++;
            display(currentStudent);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentStudent--;
            display(currentStudent);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (addFormAvailable)
            {
                AddStudentForm f = new AddStudentForm(this);
                f.Show();
                addFormAvailable = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setupEditEnvironment(true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool close = true;
            TextBox[] editableBoxes = { this.textBox1, this.textBox2, this.textBox3, this.textBox4, this.textBox5, this.textBox9, this.textBox10 };
            try
            {
                students[currentStudent].registrationNumber = Int32.Parse(this.textBox1.Text);
                students[currentStudent].studentName = this.textBox2.Text;
                students[currentStudent].classNumber = Int32.Parse(this.textBox9.Text);
                students[currentStudent].subject1Score = Int32.Parse(this.textBox3.Text);
                students[currentStudent].subject2Score = Int32.Parse(this.textBox4.Text);
                students[currentStudent].subject3Score = Int32.Parse(this.textBox5.Text);
                students[currentStudent].groupCode = Convert.ToChar(this.textBox10.Text);
            }
            catch
            {            }
            
            if (close)
            {
                setupEditEnvironment(false);
                display(currentStudent);
            }
        }

        private void setupEditEnvironment(bool edit)
        {
            this.button6.Visible = edit;
            this.button6.Enabled = edit;
            Button[] disableButtons = { this.button1, this.button2, this.button3, this.button4, this.button5, this.button7 };
            TextBox[] editableBoxes = { this.textBox1, this.textBox2, this.textBox3, this.textBox4, this.textBox5, this.textBox9, this.textBox10 };

            foreach (TextBox t in editableBoxes)
                t.ReadOnly = !edit;
            foreach (Button b in disableButtons)
                b.Enabled = !edit;

            if (currentStudent == 0)
                this.button2.Enabled = false;
            if (currentStudent == students.Count() -1)
                this.button1.Enabled = false;

            if (edit)
                for (int i = 2; i < 5; i++)
                {
                    editableBoxes[i].BackColor = SystemColors.Control;
                    editableBoxes[i].ForeColor = SystemColors.WindowText;
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result1;
            result1 = MessageBox.Show("Are you sure you want to remove this student? \n(This change cannot be undone automatically.)", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result1 == DialogResult.Yes)
            {
                if (currentStudent < 0)
                    currentStudent = 0;
                if (currentStudent > students.Count() - 1)
                    currentStudent = students.Count() - 1;

                students.RemoveAt(currentStudent);
                if (students.Count > 0)
                    display(currentStudent);
                else
                    emptyForm();
            }
        }

        private void emptyForm()
        {
            TextBox[] allBoxes = { this.textBox1, this.textBox2, this.textBox3, this.textBox4, this.textBox5, this.textBox6, this.textBox9, this.textBox10 };
            Button[] notAdd = { this.button1, this.button2, this.button4, this.button5, this.button6, this.button7 };

            foreach (TextBox t in allBoxes)
                t.Text = "";
            foreach (Button b in notAdd)
                b.Enabled = false;

            this.panel1.Visible = false;
            this.panel2.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (searchFormAvailable)
            {
                Form2 f = new Form2(this);
                f.Show();
                searchFormAvailable = false;
            }
        }
    }

    
}
