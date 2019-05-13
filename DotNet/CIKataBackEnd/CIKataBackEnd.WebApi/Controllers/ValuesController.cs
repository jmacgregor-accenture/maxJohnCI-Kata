using System.Collections.Generic;
using CIKataBackEnd.WebApi.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace RONCBackEnd.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private BusinessLogicService _businessLogicService = new BusinessLogicService();

        // GET api/values/
        [HttpGet]
        public JsonResult Get()
        {
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");

            var returnString = _businessLogicService.MakeUpValue();

            if (string.IsNullOrEmpty(returnString))
            {
                return new JsonResult("Call Did Not Work");
            }
            
            return new JsonResult(returnString);
        }

    }
}