using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapOfArraysAndCollections.Classes
{
    internal struct Product
    {
        private int _id;
        private string _name;
        private string _description;

        // Creating a properties using expression-bodied member syntax:
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }

        public Product(int id, string name, string description)
        {
            _id = id;
            _name = name;
            _description = description;
        }

        public override string ToString()
        {
            return $"Id:{_id}, Name:{_name}, Description:{_description}";
        }
    }
}
