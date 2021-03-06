﻿namespace ProgramistaNorthwind.Controllers
{
    using EF;
    using EF.Repository;
    using Microsoft.AspNetCore.Mvc;
    using Models.Custumers;
    using System.Collections.Generic;
    using System.Linq;

    [Route("api/[controller]")]
    public class CustumersController : Controller
    {
        private CustomerRepository _repo {get;set;}
        public CustumersController(NorthwindContext context)
        {
            _repo = new CustomerRepository(context);
        }

        // GET api/custumers
        [HttpGet]
        public IEnumerable<CustumerIndex> GetIndex()
        {
            return _repo.GetAll().Select(item => new CustumerIndex()
            {
                Id = item.CustomerID,
                CompanyName = item.CompanyName,
                Address = string.Format("{0} {1} {2} {3}", item.Address, item.City, item.PostalCode, item.Country),
                ContactName = item.ContactName,
                ContactTitle = item.ContactTitle,
                Phone = item.Phone                
            });
        }

        // GET api/custumers/5
        [HttpGet("{id}")]
        public CustumerDetail Get(string id)
        {
            var repoResult = _repo.Get(id);

            if (repoResult == null)
            {
                return new CustumerDetail();
            }

            return new CustumerDetail()
            {
                Address = repoResult.Address,
                City = repoResult.City,
                CompanyName = repoResult.CompanyName,
                ContactName = repoResult.ContactName,
                ContactTitle = repoResult.ContactTitle,
                Country = repoResult.Country,
                Fax = repoResult.Fax,
                Phone = repoResult.Phone,
                PostalCode = repoResult.PostalCode,
                Region = (repoResult.Region == null)? "" : repoResult.Region
            };
        }

        // POST api/custumers
        [HttpPost]
        public void Post([FromBody]CustumerDetail value)
        {
            
        }

        // PUT api/custumers/
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]CustumerDetail value)
        {

        }

        // DELETE api/custumers/
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
