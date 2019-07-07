using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Actio.Common.Commands;
using RawRabbit;

namespace Actio.API.Controllers
{

    [Route("[controller]")]
    public class UsersController : Controller
    {

        private readonly IBusClient _busClient;

        public UsersController(IBusClient busClient)
        {
            _busClient = busClient;

        }


        [HttpPost("register")]
        public async Task<IActionResult> Post([FromBody]CreateUser command)
        {
            await _busClient.PublishAsync(command);
            return Accepted();
        }

    }
}