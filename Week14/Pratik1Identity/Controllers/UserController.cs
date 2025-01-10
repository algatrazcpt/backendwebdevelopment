using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Pratik1Identity.Models;
namespace Pratik1Identity.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController:ControllerBase
    {

        [HttpPost]
        public IActionResult Post(Users user)
        {
            if(ModelState.IsValid)
            {
                return Ok("Kullanici eklendi");
            }



            return NotFound();
        }




    }
}
