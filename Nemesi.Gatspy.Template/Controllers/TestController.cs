using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nemesi.Gatspy.Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("[action]")]
        public IEnumerable<Day> UpcomingWeek()
        {
            return Enumerable.Range(0, 6).Select(index => new Day
            {
                DayOfWeek = DateTime.Today.AddDays(index).DayOfWeek.ToString(),
                Date = DateTime.Today.AddDays(index).ToShortDateString()
            });
        }

        public class Day
        {
            public string DayOfWeek { get; set; }
            public string Date { get; set; }
        }
    }
}
