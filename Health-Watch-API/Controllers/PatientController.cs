using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Health_Watch_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        public PatientController()
        {

        }
        [HttpGet]
        public async Task<IActionResult> Get(int user)
        {
            return null;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return null;
        }

        [HttpPost]
        public async Task<IActionResult> Add(string user)
        {
            return null;
        }

        [HttpPost]
        public async Task<IActionResult> Update(string user)
        {
            return null;
        }
    }
}
