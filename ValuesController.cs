using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Countries_Web.Controllers
{
    
        [Route("api/[controller]")]
        [ApiController]
        public class ValuesController : ControllerBase
        {
            private readonly Queries _queries;
            public ValuesController(Queries queries)
            {
                _queries = queries;
            }
            [HttpGet]
            public async Task<IActionResult> Get()
            {
                var countries = await _queries.GetCountries();
                return new JsonResult(countries);
            }   

        }
}
