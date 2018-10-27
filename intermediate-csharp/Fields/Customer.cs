using System;
using System.Collections.Generic;

namespace Fields
{
    class Customer
    {
       public int Id;
       public string Name;
       public readonly List<Order> Orders = new List<Order>(); // Always initialised no matter which constructor is called


       public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            // This would re-initialise the list and overwrite it unless it is readonly
            // Orders = new List<Order>();
        }
    }
}
