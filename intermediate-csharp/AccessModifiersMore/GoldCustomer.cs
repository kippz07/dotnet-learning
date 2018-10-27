using System;
using library;

namespace AccessModifiersMore
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            var result = this.CalculateRating(excludeOrders: true);
        }
    }
}