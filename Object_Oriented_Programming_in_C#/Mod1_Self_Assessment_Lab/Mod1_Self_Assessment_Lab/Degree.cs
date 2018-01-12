using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Self_Assessment_Lab
{
    class Degree
    {
        public Degree(string degree)
        {
            this.DegreeName = degree;
        }

        private string degree;
        public string DegreeName { get; set; }

        public Course ProgrammingWithCSharp = new Course("Programming With C#");
        
    }
}
