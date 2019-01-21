using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TypicalRenderSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("render")]
        public ActionResult<string> RenderByNode(int id)
        {
            var htmlContent = "<div>Hello</div><div>World</div>";
            return Content(htmlContent, "text/html");
        }
    }
}
