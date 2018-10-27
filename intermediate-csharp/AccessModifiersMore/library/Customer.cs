using System;

namespace library
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);
            if (rating == 0)
                System.Console.WriteLine("Promoted to level 1");
            else 
                System.Console.WriteLine("Promoted to level 2");
        }

        // Protected means it can be accessed in GoldCustomer as it inherits from Customer
        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}