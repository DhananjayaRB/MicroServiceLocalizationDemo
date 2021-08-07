using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceLocalizationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalizationController : ControllerBase
    {
        private readonly IStringLocalizer<SharedResource> _localizer;
        public LocalizationController(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
        }
        [HttpGet]
        public string Get(string name)
        {
            return  string.Format(_localizer["WelcomeMsg"], name);
        }


    }
}
