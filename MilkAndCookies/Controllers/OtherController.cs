using Microsoft.AspNetCore.Mvc;

namespace MilkAndCookies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtherController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            if (Request.Cookies["favoriteMilkshake"] == null) return "No cookie found";
            return Request.Cookies["favoriteMilkshake"]!;
        }
        [HttpDelete]
        public void Delete()
        {
            if (Request.Cookies["favoriteMilkshake"] != null) Response.Cookies.Delete("favoriteMilkshake");
        }

    }
}
