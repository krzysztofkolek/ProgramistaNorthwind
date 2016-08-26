using ProgramistaNorthwind.EF.Model;

namespace ProgramistaNorthwind.EF.Repository
{
    public partial class OrderRepository : BaseRepository<Order>
    {
        public OrderRepository(NorthwindContext context) : base(context)
        {
        }
    }
}
