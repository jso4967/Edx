using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Self_Assessment_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            UProgram Information_Technology = new UProgram("Information Technology");
            Console.WriteLine(Information_Technology.Name + " contains " + Information_Technology.Bachelor.DegreeName + " degree");
            Console.WriteLine("In that degree, there is a course called " + Information_Technology.Bachelor.ProgrammingWithCSharp.CourseName);
            Console.WriteLine("And there are " + Student.CountStudents() + " students in this course!");

        }
    }
}
