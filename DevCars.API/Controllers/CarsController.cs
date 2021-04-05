using DevCars.API.InputModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCars.API.Controllers
{

    [Route("api/cars")]
    public class CarsController : ControllerBase
    {
        //GET api/cars
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        //api/cars/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        //POST api/cars
        [HttpPost]
        public IActionResult Post([FromBody] AddCarInputModel model)
        {
            return Ok();

        }

        //PUT api/cars/1
        [HttpPut("{id}")]
        public IActionResult Put(int id , [FromBody]UpdateCarInputModels model )
        {
            return Ok();

        }

        //DELETE api/cars/2
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();

        }
    }
}