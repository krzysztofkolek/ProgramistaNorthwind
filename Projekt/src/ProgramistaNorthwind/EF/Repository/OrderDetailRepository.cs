using ProgramistaNorthwind.EF.Model;

namespace ProgramistaNorthwind.EF.Repository
{

    public partial class OrderDetailRepository : BaseRepository<Order_Detail>
    {
        public OrderDetailRepository(NorthwindContext context) : base(context)
        {
        }
    }
}
