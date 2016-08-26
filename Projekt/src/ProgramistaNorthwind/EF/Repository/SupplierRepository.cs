using ProgramistaNorthwind.EF.Model;

namespace ProgramistaNorthwind.EF.Repository
{
    public partial class SupplierRepository : BaseRepository<Supplier>
    {
        public SupplierRepository(NorthwindContext context) : base(context)
        {
        }
    }
}
