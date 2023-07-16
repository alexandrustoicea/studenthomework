using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHomework
{
    class Student
    {
        string _fullname;
        int age;
        int MIN_AGE = 18;
        int MAX_AGE = 99;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < MIN_AGE || value > MAX_AGE)
                {
                    throw new ArgumentOutOfRangeException("This person doesn't have a valid age to be a student!");
                    //Console.WriteLine("The age is not valid for being a student.");
                }
                else age = value;
            }
        }

        public int? Mark { get; set; }

        public Student(string fullname, int age)
        {
            _fullname = fullname;
            Age = age;
        }

        public string Info
        {
            get
            {
                return "Student " + _fullname + " is " + age + " years old.";
            }
        }
    }
}
