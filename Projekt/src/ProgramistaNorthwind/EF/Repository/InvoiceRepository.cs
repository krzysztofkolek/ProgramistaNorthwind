using ProgramistaNorthwind.EF.Model;

namespace ProgramistaNorthwind.EF.Repository
{
    public partial class InvoiceRepository : BaseRepository<Invoice>
    {
        public InvoiceRepository(NorthwindContext context) : base(context)
        {
        }
    }
}
