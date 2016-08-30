namespace ProgramistaNorthwind.Controllers
{
    using EF;
    using EF.Repository;
    using Microsoft.AspNetCore.Mvc;
    using Models.Employees;
    using System.Collections.Generic;
    using System.Linq;

    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private EmployeeRepository _repo { get; set; }

        public EmployeesController(NorthwindContext context)
        {
            _repo = new EmployeeRepository(context);
        }

        // GET api/employee
        [HttpGet]
        public IEnumerable<EmployeeIndex> GetIndex()
        {
            return _repo.GetAll().Select(item => new EmployeeIndex()
            {
                Id = item.EmployeeID,
                Name = string.Format("{0} {1}", item.FirstName, item.LastName),
                DateOfhire = (item.HireDate.HasValue) ? item.HireDate.Value.ToString() : "",
                JobTitle = item.Title
            });
        }

        // GET api/employee/5
        [HttpGet("{id}")]
        public EmployeeDetails Get(int id)
        {
            return new EmployeeDetails();
        }

        // POST api/employee
        [HttpPost]
        public void Post([FromBody]EmployeeDetails value)
        {

        }

        // PUT api/employee/
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]EmployeeDetails value)
        {

        }

        // DELETE api/employee/
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
