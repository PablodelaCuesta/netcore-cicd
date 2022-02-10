using Microsoft.AspNetCore.Mvc;

namespace netcore_cicd.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;

   public UserController(ILogger<UserController> logger) {
       _logger = logger
   }

   [HttpGet]
   public IEnumerable<string> Get()
   {
       return ["Ejemplo1", "ejemplo2"]
   }


}
