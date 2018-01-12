using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Self_Assessment_Lab
{
    class Course
    {
        private string courseName;
        public string CourseName { get; set; }

        public Course(string coursename)
        {
            this.CourseName = coursename;
        }

        public Student student1 = new Student();
        public Student student2 = new Student();
        public Student student3 = new Student();

        public Teacher teacher1 = new Teacher();

    }
}
