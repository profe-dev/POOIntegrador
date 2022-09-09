using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.BL
{
    class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }

        //Save
        public bool Save(OrderDetail newOrder)
        {
            return true;
        }

        //Get All
        public List<OrderDetail> GetAll()
        {
            return new List<OrderDetail>();
        }

        //Get ById
        public OrderDetail GetById(int id)
        {
            return new OrderDetail();
        }

        //Delete
        public bool Delete(int id)
        {
            return true;
        }
    }
}
