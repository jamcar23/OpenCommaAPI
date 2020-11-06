using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenCommaAPI.Controllers
{
    [Route("me")]
    [ApiController]
    [ApiVersion("1")]
    public class AccountController : Controller
    {
        [HttpGet]
        [MapToApiVersion("1")]
        public IActionResult Profile()
        {
            return Ok("General kenobi");
        }

        [HttpGet]
        [Route("devices")]
        [MapToApiVersion("1")]
        public IActionResult Devices()
        {
            return Ok(new[] { "eon", "C2" });
        }
    }
}
