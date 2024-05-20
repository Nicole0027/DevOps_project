using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;

namespace demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {

        public DemoController()
        { }

        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://function-app-devops-project.azurewebsites.net/api/HttpTrigger1?code=njjVsKC8IR9qRmvH_mE91CkxZPa91qGCNfD0b1i0k3iLAzFuno4x5A%3D%3D");
            var text = await response.Content.ReadAsStringAsync();

            return new OkObjectResult(text);
        }
    }
}