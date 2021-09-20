using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductOffers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private OfferService objOfferService = null;
        public ProductController()
        {
           objOfferService = new OfferService();
        }

        public async Task< List<Product>> GetAllProducts()
        {
            List<Product> lstProduct = new List<Product>();
            try
            {
                lstProduct = objOfferService.GetAllProducts();
            }
            catch (Exception)
            {

                throw;
            }
            return lstProduct;
        }
    }
}
