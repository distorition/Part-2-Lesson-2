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
    public class AgentsController : ControllerBase
    {
        private readonly ClassForList classForList;

        [HttpPost("register")]
        public IActionResult RegisterAgent([FromBody] AgentInfo agentInfo)
        {
            classForList.Metrics.Add(agentInfo);
            return Ok();
        }

        [HttpPut("enable/{agentId}")]
        public IActionResult EnableAgent ([FromRoute] int agentId)
        {
          
            return Ok();
        }

        [HttpPut("disable/{agentID}")]
        public IActionResult DisableAgent([FromRoute] int agentID)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult GetMetriksLIst([FromBody] ClassForList classFor)
        {
            return Ok(classFor.Metrics);
        }


      
    }
}
