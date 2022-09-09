using System;
using System.Collections.Generic;
using System.Text;

namespace TheStore.BL
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        //Save
        public bool Save(Product newProduct)
        {
            return true;
        }

        //Get All
        public List<Product> GetAll()
        {
            return new List<Product>();
        }

        //Get by id
        public Product GetById(int id)
        {
            return new Product();
        }

        //Delete
        public bool Delete(int id)
        {
            return true;
        }
    }
}
