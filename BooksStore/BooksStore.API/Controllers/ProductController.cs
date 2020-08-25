using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksStore.Repository;
using BooksStore.Repository.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _uow;

        public ProductController(IProductRepository productRepository, IUnitOfWork uow)
        {
            _productRepository = productRepository;
            _uow = uow;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get()
        {
            var products = await _productRepository.GetAll();
            return Ok(products);
        }
    }
}