using DevCars.API.InputModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCars.API.Controllers
{
    public class CustomersController : ControllerBase
    {

        //POST api/costumers
        [HttpPost]
        public IActionResult Post([FromBody]AddCustomerInputModel model)
        {
            return Ok();
        }


        //POST api/costumers/1/orders
        [HttpPost("{id}")]
        public IActionResult PostOrder(int id , [FromBody] AddOrderInputModel model)
        {
            return Ok();
        }

        
        //GET api/costumers/1/orders/3
        [HttpGet("{id}/orders/{orderid}")]
        public IActionResult GetOrder(int id, int orderid)
        {
            return Ok();
        }
    }
}
