using Catalog.Dtos;
using IntegrifyCsharp;
using IntegrifyCsharp.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers{

    [Route("api/[controller]")]
    [ApiController]

    public class AccountController : ControllerBase{
        [HttpPost]
        [Route("Login")]
       // public IActionResult Login([FromForm]AuthenticationRequest authenticationRequest, UserDto userDto){
        public IActionResult Login([FromForm]AuthenticationRequest authenticationRequest){    
            var jwtAuthenticationManager = new JwtAuthenticationManager();
            //var userDto1 = new UserDto();
            var authResult = jwtAuthenticationManager.Authenticate(authenticationRequest.UserName, authenticationRequest.Password);
            if (authResult != null)
                return Ok(authResult);
            else
                return Unauthorized();

        }


    }
}
