using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part_2_Lesson_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControolerToTakeMetrics : ControllerBase
    {
        
       
        [HttpGet("api/metrics/cpu/from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricsFromCpu([FromRoute] TimeSpan fromTinme, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
        [HttpGet("api/metrics/DotNet/from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricsFromDotNet([FromRoute] TimeSpan fromTinme, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
        [HttpGet("api/metrics/Hdd/from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricsFromHdd([FromRoute] TimeSpan fromTinme, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }

        [HttpGet("api/metrics/Network/from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricsFromNetwork([FromRoute] TimeSpan fromTinme, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }
}
