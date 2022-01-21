using System;
using System.Collections.Generic;

namespace ExamFirstSemester
{
    public class CustomerCatalog
    {
         private List<Customer> _customers;

        
        public CustomerCatalog()
        {
            _customers = new List<Customer>();
        }
        
        public CustomerCatalog(List<Customer> customers)
        {
            if (customers == null) _customers = new List<Customer>();

            else
            {
                customers.RemoveAll(customer => customer == null);
                _customers = customers;
            }
        }

        public List<Customer> Customers => _customers;

        public Customer Search(string firstName, string lastName)
        {
            Customer customer = _customers.Find(customer => customer.Name == firstName && customer.LastName == lastName);
            if(customer == null) throw new ArgumentNullException("Does not exist");
            return customer;
        }
        
        public void Add(Customer customer)
        {
            if (customer == null) return;

            _customers.Add(customer);
        }

        public void DeleteCustomer(string name , string lastName)
        {
            try
            {
                _customers.Remove(Search(name, lastName));
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Update(string firstName, string lastName, string newFirstName, string newLastName)
        {
            try
            {
               Search(firstName, lastName).Update(newFirstName, newLastName);

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void PrintInfo()
        {
            Helpers.PrintCustomerHelp("Customers" , ToString());
        }

        public override string ToString()
        {
            string customers = "";

            for (int i = 0; i < _customers.Count; i++)
            {
                customers += _customers[i].ToString();

                if (i < _customers.Count - 1)
                {
                    customers += "\n";
                }

            }

            return customers;
        }


    }
}