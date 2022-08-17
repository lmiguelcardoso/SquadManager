using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AP1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Autentica o usuario
        /// </summary>
        /// <param name="username">Username do Usuario</param>
        /// <param name="password">Senha do usuario</param>
        /// <returns>OK 200</returns>
        [HttpPost]
        public IActionResult Login(UserViewModel user)
        {
            if (user.Email == "admin" && user.Password == "admin")
                return Ok(new { status = "Usuario Logado" });

            return BadRequest(new { status = "Usuario nao existe" });

        }

        [HttpPost("create")]
   
        public IActionResult SignUp(UserViewModel user)
        {

            return Ok(new { status = "Usuario cadastrado" });

        }
    }
}
