namespace RecapOfArraysAndCollections.Classes
{
    internal class Customer
    {
        private int _id;
        private string _firstName;
        private string _lastName;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {                             // Creating a property here using 
            get => _lastName;         // expression-bodied member syntax:
            set => _lastName = value; // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members
        }

        public Customer()
        {
            _id = 0;
            _firstName = "";
            _lastName = "";
        }

        public Customer(int id, string firstName, string lastName)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
        }

        public override string ToString()
        {
            return $"Id:{_id}, First Name:{_firstName}, Last Name:{_lastName}";
        }
    }
}
