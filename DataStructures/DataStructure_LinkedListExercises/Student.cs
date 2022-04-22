using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_LinkedList
{
    internal class Student
    {
        private int studentNumber;
        private string name;

        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return $"{studentNumber}, {Name}";
        }
    }
}
