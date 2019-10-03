using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LamdaShoppingList.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ORMBenchMark;

namespace LamdaShoppingList.Controllers
{
    [Route("v1/Customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        List<Customer> cust = new List<Customer>();
        [HttpGet]
        public IActionResult GetCustomer()
        {
            DapperRepository _DapperRepo = new DapperRepository();
            string test= "Postgrey";
            //cust = _DapperRepo.GetUsersWithDapper();
            return Ok(test);

        }
    }
}