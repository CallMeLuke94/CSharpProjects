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
    public partial class AddStudentForm : Form
    {
        Form1 F;

        public AddStudentForm(Form1 form)
        {
            F = form;
            InitializeComponent();
        }

        private void AddStudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            F.addFormAvailable = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool canSubmit = true;
            bool proceed = true;
            int reg = -1;
            string name = null;
            int classNo = -1;
            char group = 'U';
            int[] subMarks = { -1, -1, -1 };
            TextBox[] allBoxes = { this.textBox1, this.textBox2, this.textBox3, this.textBox4, this.textBox5, this.textBox6, this.textBox7 };
            TextBox[] subjectBoxes = { this.textBox5, this.textBox6, this.textBox7 };

            foreach (TextBox b in allBoxes)
            {
                if (b.Text == "")
                {
                    MessageBox.Show("You cannot leave any fields blank.");
                    proceed = false;
                    break;
                }
            }

            if (proceed)
            {
                try
                {
                    reg = Int32.Parse(this.textBox1.Text);
                }
                catch
                {
                    MessageBox.Show("Registration Number must be a number.");
                    canSubmit = false;
                }
                try
                {
                    name = this.textBox2.Text;
                    if (name == null)
                        throw new Exception();
                }
                catch
                {
                    MessageBox.Show("The name field cannot be blank.");
                    canSubmit = false;
                }
                try
                {
                    classNo = Int32.Parse(this.textBox3.Text);
                }
                catch
                {
                    MessageBox.Show("Class Number must be a number.");
                    canSubmit = false;
                }
                try
                {
                    if (Convert.ToChar(this.textBox4.Text) == 'B' || this.textBox4.Text == "Business")
                        group = 'B';
                    else if (Convert.ToChar(this.textBox4.Text) == 'C' || this.textBox4.Text == "Computing")
                        group = 'C';
                    else
                        group = 'U';
                }
                catch
                {
                    group = 'U';
                }

                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        subMarks[i] = Int32.Parse(subjectBoxes[i].Text);
                    }
                    catch
                    {
                        int k = i + 1;
                        MessageBox.Show("Subject " + k + " Score must be a number.");
                        canSubmit = false;
                    }
                }
            }

            if (canSubmit && proceed)
            {
                F.students.Add(new Student(reg, name, classNo, group, subMarks[0], subMarks[1], subMarks[2]));
                this.Close();
                F.display(F.students.Count() - 1);
            }
        }
    }
}
