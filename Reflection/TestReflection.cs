using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Reflection
{
    internal class TestReflection
    {
        public int Id { get; set; } = 50;
        public string Name { get; set; } = "Rasel";
        public string Description { get; set; } = "Test for Reflection";
        public TestReflection(string name)
        {
            Console.WriteLine("Print my name :" +name);
        }

        public string getMyDetailsInformation()
        {
            return "Name :" + Name + " Description " + Description;
        }
    }
}
