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
    public partial class SpecificSearch : Form
    {
        Form2 F;

        public SpecificSearch(Form2 form)
        {
            F = form;
            InitializeComponent();
        }

        private void SpecificSearch_Load(object sender, EventArgs e)
        {

        }

        private void SpecificSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            F.advancedFormAvailable = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F.resetSearchValues();
            bool proceed = true;

            if (this.textBox1.Text != "")
            {
                try
                {
                    F.findRegNo = Int32.Parse(this.textBox1.Text);
                }
                catch
                {
                    MessageBox.Show("Registation Numbers must be integers.");
                    proceed = false;
                }
            }
            if (proceed && this.textBox2.Text != "")
            {
                F.findName = this.textBox2.Text;
            }
            if(proceed && this.textBox3.Text != "")
            {
                try
                {
                    int temp = Int32.Parse(this.textBox3.Text);
                    if (temp < 0)
                        F.findClass = 0;
                    else if (temp > 9)
                        F.findClass = 9;
                    else
                        F.findClass = temp;
                }
                catch
                {
                    MessageBox.Show("Class Numbers must be integers.");
                    proceed = false;
                }
            }
            if (proceed && this.textBox4.Text != "")
            {
                char temp = this.textBox4.Text.ToUpper().ToCharArray()[0];
                if (temp == 'B' || temp == 'C')
                    F.findGroup = temp;
                else
                    F.findGroup = 'U';
            }
            if (proceed && this.textBox5.Text != "")
            {
                try
                {
                    int temp1 = Int32.Parse(this.textBox5.Text);
                    if (temp1 < 0)
                        F.findSub1 = 0;
                    else if (temp1 > 150)
                        F.findSub1 = 150;
                    else
                        F.findSub1 = temp1;
                }
                catch
                {
                    MessageBox.Show("Subject Scores must be integers.");
                    proceed = false;
                }
            }
            if (proceed && this.textBox6.Text != "")
            {
                try
                {
                    int temp2 = Int32.Parse(this.textBox6.Text);
                    if (temp2 < 0)
                        F.findSub2 = 0;
                    else if (temp2 > 150)
                        F.findSub2 = 150;
                    else
                        F.findSub2 = temp2;
                }
                catch
                {
                    MessageBox.Show("Subject Scores must be integers.");
                    proceed = false;
                }
            }
            if (proceed && this.textBox7.Text != "")
            {
                try
                {
                    int temp3 = Int32.Parse(this.textBox7.Text);
                    if (temp3 < 0)
                        F.findSub3 = 0;
                    else if (temp3 > 150)
                        F.findSub3 = 150;
                    else
                        F.findSub3 = temp3;
                }
                catch
                {
                    MessageBox.Show("Subject Scores must be integers.");
                    proceed = false;
                }
            }
            if (proceed)
            {
                F.search();
                this.Close();
            }
        }
    }
}
