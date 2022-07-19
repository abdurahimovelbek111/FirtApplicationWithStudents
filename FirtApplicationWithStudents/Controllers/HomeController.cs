using FirtApplicationWithStudents.Interface;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace FirtApplicationWithStudents.Controllers
{
    [Route("users/")]
    public class HomeController : Controller
    {

        //1-usul  Bu Hamma metodlarda ishliydi
        //private IUserService _userService;
        //public HomeController(IUserService userService)
        //{
        //    _userService = userService;
        //}
        //2-usul bunda faqat bitta Metod ichida ishlaydi. Boshqa funksiyalarda ham berish uchun tepada elon qilib quyish kerak.
        // [FromServices] IUserService _userService
        [HttpGet()]
        public ActionResult GetUsers([FromServices] IUserService _userService)
        {

            //int[] array = new int[2] { 164589, 224 };
            //return Ok(array[2]);
            Log.Warning("GetUsers action is working");
            return Ok(_userService.GetUsers());
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++

        #region Route bilan ishlash
        //[HttpPost("{name}")]
        //public JsonResult Category(string name)
        //{
        //    return new JsonResult(new { name = "name" });
        //}
        //++++++++++++++++++++++++++++++
        //[HttpPost("{name}")]
        //public ActionResult Category2(string name)
        //{
        //  if (name == "Saloma")
        //        return Created("",new { name = "Alooo" });

        //    return NotFound();
        //  //   return BadRequest();
        //}
        //++++++++++++++++++++++++++++++++
        //[HttpPost("category/jamiyat")]
        //public string Hello() => "Hello World";
        //[HttpPost("salom")]
        //public string Salom() => "Salom Dunyo";
        //[HttpPost("jahon")]
        //public string Jahon() => "Jigitdi gullari qandaysizlar";
        //[HttpPost("kun")]
        //public string Kun() => "Bugun kun juda ham issiq buldi";
        #endregion
    }
}
