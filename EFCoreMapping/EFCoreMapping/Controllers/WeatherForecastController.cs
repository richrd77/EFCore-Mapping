using EFCoreMapping.OneToOneMapping;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreMapping.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        /// <summary>
        /// Injecting this from the constructor using dotnet Core DI
        /// in real world app we access context obj in repository (service & repository Design Pattern)
        /// </summary>
        private readonly MyDBContext context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            MyDBContext context)
        {
            _logger = logger;
            this.context = context;
        }

        [HttpGet]
        public IActionResult GetOneOnOne()
        {
            return Ok(context.OneonOneParent
                .Include(p => p.Child) //by default EFCore doesn't include Child obj for performance reasons
                .Select(p => p.ToString()).ToList());
        }

        [HttpPost]
        public IActionResult CreateOneOnOne()
        {
            // normally this object would be posted by the client
            var p = new OneParent
            {
                Name = "Parent -> one to one relation",
                Child = new OneChild
                {
                    Name = "Child -> one to one relation"
                }
            };
            context.OneonOneParent.Add(p);

            //above line just adds the new item to the context object and stores in-memory
            //in order to reflect this in DB we need to call below line of code
            context.SaveChanges();
            return Ok("success");
        }
    }
}
