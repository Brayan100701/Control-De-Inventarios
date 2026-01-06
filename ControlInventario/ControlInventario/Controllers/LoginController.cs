using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControlInventario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet]
        public string GetAccess(Test username)
        {
            return username.Username;
        }
    }

    public class Test
    {
        public string Username { get; set; }
    }
}
