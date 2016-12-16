using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultsApp
{
    public partial class Form2 : Form
    {
        Form1 F;
        public bool advancedFormAvailable = true;
        public int findRegNo = -1;
        public string findName = "";
        public int findClass = -1;
        public char findGroup = ' ';
        public int findSub1 = -1;
        public int findSub2 = -1;
        public int findSub3 = -1;

        public Form2(Form1 form)
        {
            F = form;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Student s in F.students)
                studentBindingSource.Add(s);
        }

        private void studentBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentBindingSource.Clear();
            this.radioButton1.Checked = false;
            this.radioButton2.Checked = false;

            foreach (Student s in F.students)
                studentBindingSource.Add(s);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                studentBindingSource.Clear();
                foreach (Student s in F.students)
                {
                    if (s.groupCode == 'C')
                        studentBindingSource.Add(s);
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
            {
                studentBindingSource.Clear();
                foreach (Student s in F.students)
                {
                    if (s.groupCode == 'B')
                        studentBindingSource.Add(s);
                }
            }
        }

        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (advancedFormAvailable)
            {
                SpecificSearch s = new SpecificSearch(this);
                s.Show();
                advancedFormAvailable = false;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            F.searchFormAvailable = true;
        }

        public void resetSearchValues()
        {
            findRegNo = -1;
            findName = "";
            findClass = -1;
            findGroup = ' ';
            findSub1 = -1;
            findSub2 = -1;
            findSub3 = -1;
        }

        public void search()
        {
            studentBindingSource.Clear();
            foreach (Student s in F.students)
                studentBindingSource.Add(s);

            foreach (Student s in F.students)
            {
                if (findRegNo != -1 && s.registrationNumber != findRegNo)
                    studentBindingSource.Remove(s);
                if (findName != "" && s.studentName != findName)
                    studentBindingSource.Remove(s);
                if (findClass != -1 && s.classNumber != findClass)
                    studentBindingSource.Remove(s);
                if (findGroup != ' ' && s.groupCode != findGroup)
                    studentBindingSource.Remove(s);
                if (findSub1 != -1 && s.subject1Score != findSub1)
                    studentBindingSource.Remove(s);
                if (findSub2 != -1 && s.subject2Score != findSub2)
                    studentBindingSource.Remove(s);
                if (findSub3 != -1 && s.subject3Score != findSub3)
                    studentBindingSource.Remove(s);

            }
                
        }

        private void xmlButton_Click(object sender, EventArgs e)
        {
            XDeclaration declaration = new XDeclaration("1.0", "utf-8", "yes");
            XElement root_element = new XElement("Students");
    
            foreach (Student s in F.students)
            {
                XElement info_element = new XElement("info");
                info_element.Add(new XElement("RegNo", s.registrationNumber));
                info_element.Add(new XElement("Name", s.studentName));
                info_element.Add(new XElement("Class", s.classNumber));
                info_element.Add(new XElement("Group", s.groupCode));
                info_element.Add(new XElement("Subject1", s.subject1Score));
                info_element.Add(new XElement("Subject2", s.subject2Score));
                info_element.Add(new XElement("Subject3", s.subject3Score));
                root_element.Add(info_element);
            }

            XDocument document = new XDocument(declaration, root_element);
            try
            {
                document.Save("C:\\Student_Files\\students.xml");
                MessageBox.Show("Document has been saved to Student_Files in your C drive.");
            }
            catch
            {
                MessageBox.Show("Sorry, we were unable to save the file.");
            }
        }
    }
}
