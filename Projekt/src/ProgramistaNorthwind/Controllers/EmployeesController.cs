namespace ProgramistaNorthwind.Controllers
{
    using EF;
    using EF.Repository;
    using Microsoft.AspNetCore.Mvc;

    public class EmployeesController : Controller
    {
        private EmployeeRepository _repo { get; set; }

        public EmployeesController(NorthwindContext context)
        {
            _repo = new EmployeeRepository(context);
        }
    }
}
