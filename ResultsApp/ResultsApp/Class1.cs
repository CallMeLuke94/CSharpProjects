using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsApp
{
    public class Student
    {
        private int RegNo; //any number
        private string name; //any string
        private int classNo; //1-9
        private char group; // B-C
        private int subject1; //0-150
        private int subject2; //0-150
        private int subject3; //0-150

        public Student(int r, string n, int c, char g, int s1, int s2, int s3)
        {
            registrationNumber = r;
            studentName = n;
            classNumber = c;
            groupCode = g;
            subject1Score = s1;
            subject2Score = s2;
            subject3Score = s3;
        }

        public int registrationNumber
        {
            get { return RegNo; }
            set
            {
                if (value < 1)
                    RegNo = 1;
                else
                    RegNo = value;
            }
        }

        public string studentName
        {
            get { return name; }
            set { name = value; }
        }

        public int classNumber
        {
            get { return classNo; }
            set
            {
                if (value < 1)
                    classNo = 1;
                else if (value > 9)
                    classNo = 9;
                else
                    classNo = value;
            }
        }

        public char groupCode
        {
            get { return group; }
            set { group = value; }
        }

        public int subject1Score
        {
            get { return subject1; }
            set
            {
                if (value < 0)
                    subject1 = 0;
                else if (value > 150)
                    subject1 = 150;
                else
                    subject1 = value;
            }
        }

        public int subject2Score
        {
            get { return subject2; }
            set
            {
                if (value < 0)
                    subject2 = 0;
                else if (value > 150)
                    subject2 = 150;
                else
                    subject2 = value;
            }
        }

        public int subject3Score
        {
            get { return subject3; }
            set
            {
                if (value < 0)
                    subject3 = 0;
                else if (value > 150)
                    subject3 = 150;
                else
                    subject3 = value;
            }
        }
    }
}
