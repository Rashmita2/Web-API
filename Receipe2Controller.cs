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
        public ActionResult GetDishes()
        {
            string[] Dishes = { "Oxtail", "Curry chicken", "Dumplings" };
            if (Dishes.Any())
                return NotFound();
            return Ok(Dishes);
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
