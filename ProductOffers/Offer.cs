using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOffers
{
    public class Offer
    {
        public string OfferName { get; set; }
        public List<Product> Products { get; set; }

        public Offer()
        {
            OfferName = "";
            Products = new List<Product>();
        }
    }

}
