using ProgramistaNorthwind.EF.Model;

namespace ProgramistaNorthwind.EF.Repository
{
    public partial class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(NorthwindContext context) : base(context)
        {
        }
    }
}
