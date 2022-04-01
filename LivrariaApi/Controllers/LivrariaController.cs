using LivrariaApi.Data;
using LivrariaApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LivrariaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrariaController : Controller
    {
        private readonly LivrariaApiContext _livrariaApiContext;

        public LivrariaController(LivrariaApiContext livrariaApiContext)
        {
            _livrariaApiContext = livrariaApiContext;
            //var product = _livrariaApiContext.Products.Find("1");

            foreach (Product x in _livrariaApiContext.Products)
                _livrariaApiContext.Products.Remove(x);
            _livrariaApiContext.SaveChanges();

            //if (product == null)
            //{
                _livrariaApiContext.Products.Add(new Product { Id = "1", Name = "Book1", Price = 24, Quantity = 25, Category = "action", Img = "img1" });
                _livrariaApiContext.Products.Add(new Product { Id = "2", Name = "Book2", Price = 50, Quantity = 10, Category = "action", Img = "img2" });
                _livrariaApiContext.Products.Add(new Product { Id = "3", Name = "Book3", Price = 20, Quantity = 2 , Category = "action", Img = "img3" });
                _livrariaApiContext.Products.Add(new Product { Id = "4", Name = "Book4", Price = 10, Quantity = 1 , Category = "action", Img = "img1" });
                _livrariaApiContext.Products.Add(new Product { Id = "5", Name = "Book5", Price = 15, Quantity = 5 , Category = "action", Img = "img1" });

                _livrariaApiContext.SaveChanges();
            //}
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> List()
        {
            return await _livrariaApiContext.Products.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetId(string id)
        {
            var product = await _livrariaApiContext.Products.FindAsync(id);

            return (product == null) ? NotFound() : Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> Post([FromBody] Product product)
        {
            _livrariaApiContext.Products.Add(product);
            await _livrariaApiContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetId), new { id = product.Id }, product);
        }
    }
}
