using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Self_Assessment_Lab
{
    class Student
    {
        private static int numberOfStudents = 0;

        public Student()
        {
            numberOfStudents++;
        }

        public static int CountStudents()
        {
            return numberOfStudents;
        }
    }
}
