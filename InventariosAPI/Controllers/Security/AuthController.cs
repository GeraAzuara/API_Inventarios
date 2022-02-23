using System.Net;
using InventariosAPI.Data.Interfaces;
using InventariosAPI.Data.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InventariosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        private IAuthService _userService;

        public AuthController(IAuthService userService)
        {
            _userService = userService;
        }

        // GET: api/Auth/Authorize
        [HttpPost("Authorize")]
        public IActionResult AuthorizeAsync([FromBody] InfoConsumidor model)
        {
            if (ModelState.IsValid)
            {
                var result = _userService.AuthorizeDefault(model);
                if (result.StatusCode == HttpStatusCode.OK)
                    return Ok(result);

                return BadRequest(result);
            }
            return BadRequest("Algunas propiedades del modelo son inválidas");
        }
    }
}