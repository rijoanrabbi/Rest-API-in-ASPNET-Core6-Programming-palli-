using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet6WebAPIDemo.Controllers
{
    [Route("api/[controller]")]//you need to use rootpath/api/controllerName
    //https://localhost:7198/api/Values
    [ApiController]//mention this is MVC controller or API controller
    public class ValuesController : ControllerBase
    {
        [HttpGet]//this called atrribute, which type of request we are use in API, get,put,post,delete.
        public string GetName()
        {
            return "welcome to new lesson";
        }

    }
}
