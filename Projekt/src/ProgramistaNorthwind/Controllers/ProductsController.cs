namespace ProgramistaNorthwind.Controllers
{
    using EF;
    using EF.Repository;
    using Microsoft.AspNetCore.Mvc;

    public class ProductsController : Controller
    {
        private ProductRepository _repo { get; set; }

        public ProductsController(NorthwindContext context)
        {
            _repo = new ProductRepository(context);
        }
    }
}
