using ProgramistaNorthwind.EF.Model;

namespace ProgramistaNorthwind.EF.Repository
{
    public partial class EmployeeRepository : BaseRepository<Employee>
    {
        public EmployeeRepository(NorthwindContext context) : base(context)
        {
        }
    }
}
