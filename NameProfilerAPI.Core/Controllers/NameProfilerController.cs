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
        INameProfilerService _nameProfilerService;

        public NameProfilerController(INameProfilerService nameProfilerService)
        {
            _nameProfilerService = nameProfilerService;
        }

        [HttpPost]
        public ActionResult<SoulPlanNumbers> ConvertNameToSoulPlanNumbers(string name)
        {
            return _nameProfilerService.GenerateSoulPlanNumbers(name);
        }
    }
}

