using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Receipe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceipeController : ControllerBase
    {
        [HttpGet]
        public string[] GetDishes()
        {
            string[] Dishes = { "Oxtail", "Curry chicken", "Dumplings" };
            return Dishes;
        }
     }
 }
