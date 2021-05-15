using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Receipe.Controllers
{
    [Route("api/[controller]")] //api/receipes
    [ApiController]
    public class ReceipeController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetDishes([FromQuery] int count)
        {
            Models.Reciperecord[] Dishes = {
                new() { Title = "Oxtail" },
                new() { Title = "Curry chicken" },
                new() { Title = "Dumplings" }
                };
            
            return Ok(Dishes.Take(count));
        }

        [HttpPost]
        public ActionResult Createnewreceipe([FromBody] Models.Reciperecord newReceipe)       
        {
            bool bad = false;
            if (bad)
            {
                return BadRequest();
         }
            return Created("", newReceipe);
        }
       
        [HttpDelete("{id}")] 
        public ActionResult DeletReceipe(string id)
        {
            bool allbad = false;
            if (allbad)
            {
                return BadRequest();
            }
            return NoContent();
        }
    }
}
