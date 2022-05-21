using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            this.Orders = new List<Order>();
        }

        public Customer(int id)
            :this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }
    }
}
