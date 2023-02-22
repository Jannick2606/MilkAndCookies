using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MilkAndCookies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MilkshakesController : ControllerBase
    {
        [HttpGet]
        public string Get(string? favoriteMilkshake)
        {
            CookieOptions co = new CookieOptions();
            co.HttpOnly = true;
            co.Secure = true;
            co.Expires = DateTimeOffset.MaxValue;
            if (favoriteMilkshake == null) return "";
            Response.Cookies.Append("favoriteMilkshake", favoriteMilkshake, co);
            return favoriteMilkshake;
        }
        [HttpGet]
        [Route("[action]")]
        public string GetFromCookie()
        {
            if (Request.Cookies["favoriteMilkshake"] == null) return "Unknown";
            return Request.Cookies["favoriteMilkshake"]!;
            
        }
    }
}
