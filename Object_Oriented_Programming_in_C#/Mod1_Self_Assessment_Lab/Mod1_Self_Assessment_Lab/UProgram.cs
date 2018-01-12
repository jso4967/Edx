using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Self_Assessment_Lab
{
    class UProgram
    {
        public UProgram(string name)
        {
            this.Name = name;
        }

        private string name;
        public string Name { get; set; }

        public Degree Bachelor = new Degree("Bachelor");
    }
}
