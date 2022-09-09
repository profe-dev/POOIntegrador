using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.BL
{
    public class Order
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }

        //Save
        public bool Save(Order newOrder)
        {
            return true;
        }

        //Get All
        public List<Order> GetAll()
        {
            return new List<Order>();
        }

        //Get ById
        public Order GetById(int id)
        {
            return new Order();
        }

        //Delete
        public bool Delete()
        {
            return true;
        }
    }
}
