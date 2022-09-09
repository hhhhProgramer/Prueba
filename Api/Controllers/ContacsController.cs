using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ContacsController : ControllerBase
{
   

    public ContacsController()
    {
        
    }

   [HttpGet]
     public async Task<IActionResult> Get()
    {
        return Ok(true);
    }
}
