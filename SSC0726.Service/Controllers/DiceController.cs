using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;

namespace SSC0726.Service.Controllers
{
    [Route("api/dice")]
    public class DiceController : Controller
    {
        [HttpGet]
        public IActionResult Index(
            [FromQuery] int sides = 6,
            [FromQuery] int amount = 1
            )
        {
            var ret = new List<int>();
            for (int i = 0; i < amount; i++)
            {
                ret.Add(new Random().Next(1, sides +1));
            }
            
            return Ok(new
            {
                Sum = ret.Aggregate((a, b) => a + b),
                Avg = ret.Average(),
                Values = ret,
                Distrib = ret
                    .OrderBy(a => a)
                    .GroupBy(a => a)
                    .ToDictionary(g => g.Key, g => g.Count())
            });
        }
    }
}