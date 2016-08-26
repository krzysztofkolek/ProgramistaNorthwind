using ProgramistaNorthwind.EF.Model;

namespace ProgramistaNorthwind.EF.Repository
{
    public partial class CustomerRepository : BaseRepository<Customer>
    {
        public CustomerRepository(NorthwindContext context) : base(context)
        {
        }
    }
}
