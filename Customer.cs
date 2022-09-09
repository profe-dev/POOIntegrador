using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.BL
{
    public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        //Save
        public bool Save(Customer newCustomer)
        {
            return true;
        }


        //Get all
        public List<Customer> GetAll()
        {
            return new List<Customer>();
        }
        //Get by id
        public Customer GetById(int id)
        {
            return new Customer();
        }
        //Delete
        public bool Delete(int id)
        {
            return true;
        }

        
    }
}
