namespace ProgramistaNorthwind.Controllers
{
    using EF;
    using EF.Repository;
    using Microsoft.AspNetCore.Mvc;
    using Models.Products;
    using System.Collections.Generic;
    using System.Linq;

    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private ProductRepository _repo { get; set; }

        public ProductsController(NorthwindContext context)
        {
            _repo = new ProductRepository(context);
        }

        // GET api/product
        [HttpGet]
        public IEnumerable<ProductIndex> GetIndex()
        {
            return _repo.GetAll().Select(item => new ProductIndex()
            {
                
            });
        }

        // GET api/product/5
        [HttpGet("{id}")]
        public ProductDetails Get(int id)
        {
            return new ProductDetails();
        }

        // POST api/product
        [HttpPost]
        public void Post([FromBody]ProductDetails value)
        {

        }

        // PUT api/product/
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]ProductDetails value)
        {

        }

        // DELETE api/product/
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
