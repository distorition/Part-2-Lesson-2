using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part_2_Lesson_2.Controllers
{
    [Route("api/metrics/DotNet")]
    [ApiController]
    public class DotNetMetricsController : ControllerBase
    {
       
        [HttpGet("agent/{agentId}/from/{FromTime}/to/{toTime}")]
        public IActionResult GetMetricsFromAgent([FromRoute] int agentId, [FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
           
            return Ok();
        }

        [HttpGet("cluster/from/{FromTime}/to/{toTime}")]
        public IActionResult GetMEtricsFormAllClusters([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }
}
