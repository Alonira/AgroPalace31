using AgroPalace31.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgroPalace31.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //private fields
        private readonly IProductRepository _productRepository;
        //constructor
        public ProductController( IProductRepository productRepository) 
        {
            _productRepository = productRepository;
        }


    }
}
