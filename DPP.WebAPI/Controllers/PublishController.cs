using DPP.lib.Objects.JSON;
using Microsoft.AspNetCore.Mvc;

namespace DPP.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PublishController : ControllerBase
    {
        private readonly ILogger<PublishController> _logger;

        public PublishController(ILogger<PublishController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public bool GenerateApp(Pipeline pipeline)
        {

            return true;
        }
    }
}