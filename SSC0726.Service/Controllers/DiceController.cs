using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace SSC0726.Service.Controllers
{
    [Route("api/dice")]
    public class DiceController : Controller
    {
        [HttpGet]
        [ProducesResponseType(typeof(DiceDto), 200)]
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
            
            return Ok(new DiceDto
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

    public class DiceDto
    {
        public int Sum;
        public double Avg;
        public IEnumerable<int> Values;
        public Dictionary<int, int> Distrib;
    }
}