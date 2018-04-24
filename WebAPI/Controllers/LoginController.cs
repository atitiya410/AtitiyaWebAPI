using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/Login")]
    public class LoginController : Controller
    {
   

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // POST: api/Login 
        [HttpPost]
        public IActionResult PostLogin([FromBody] Login login)
        {
            if (login.Username != "mod" && login.Password != "1234" )  //null int ... database
            {
                return BadRequest();
            }

          return Ok("Login success");
        }

    }
}
