using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Video_editor_webapi_sami_060.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        [HttpGet]
        public string SayHelloAPI()
        {
            return "Hello To API";
        }
    }
}
