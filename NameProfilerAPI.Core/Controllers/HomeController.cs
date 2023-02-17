using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NameProfilerAPI.Core.Model;

namespace NameProfilerAPI.Core.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class NameProfilerController : Controller
    {
        [HttpPost]
        public ActionResult<SoulPlanNumbers> ConvertNameToSoulPlanNumbers(string name)
        {
            return new SoulPlanNumbers { WorldlyChallenges = "13 - 4" };
        }
    }
}

