using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models.WebServerDB;

namespace WebServer.Controllers
{
    [Route("api")]
    //使用JwtBearer
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class WebApiController : Controller
    {
        private readonly WebServerDBContext _WebServerDBContext;
        private readonly IHttpContextAccessor _context;
        public WebApiController(WebServerDBContext WebServerDBContext,
            IHttpContextAccessor context)
        {
            _WebServerDBContext = WebServerDBContext;
            _context = context;
        }
        // api/Test
        [HttpPost("Test")]
        public async Task<IActionResult> Test()
        {
            try
            {
                var userID = User?.Identity?.Name;
                var user = await _WebServerDBContext.User.FindAsync(userID);
                return Json(new
                {
                    email = user?.Email,
                });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}