namespace ExamFirstSemester
{
    public class Customer
    {
        private string _name;
        private string _lastName;
        private string _address;

        public Customer(string name, string lastName, string address)
        {
            _name = name;
            _lastName = lastName;
            _address = address;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        

        public void Update(string name , string lastName)
        {
            _name = name;
            _lastName = lastName;
        }

        public override string ToString()
        {
            return $"name: {_name} {_lastName} , address: {_address}";
        }
    }
}