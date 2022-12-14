using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZHB1B8_ZH3_WEB.Models;

namespace ZHB1B8_ZH3_WEB.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class mindenController : ControllerBase
    {
        [HttpGet]
        [Route("autok/minden")]
        public IActionResult autokMind()
        {
            SoftechzhContext context = new SoftechzhContext();

            var autok = context.Autok.ToList();
            return Ok(autok);
        }

        [HttpGet]
        [Route("autok/info/{id}")]
        public IActionResult autoInfo(int id)
        {
            SoftechzhContext context = new SoftechzhContext();

            var info = (from x in context.Autok
                        where x.TermekKod == id
                        select x).FirstOrDefault();

            if (info == null) return NotFound("Nem található autó, ilyen ID-vel");
            else return Ok(info);
        }
        [HttpGet]
        [Route("ugyfelek/info/{id}")]
        public IActionResult ugyfelInfo(int id)
        {
            SoftechzhContext context = new SoftechzhContext();

            var info = (from x in context.Ugyfel
                        where x.Id == id
                        select x).FirstOrDefault();

            if (info == null) return NotFound("Nem található ügyfél, ilyen ID-vel");
            else return Ok(info);
        }
    }
}
