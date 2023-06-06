using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portal.MODEL;
using Portal.BLL;


namespace Portal.BLLService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImovelController : ControllerBase
    {
        [HttpGet(Name = "GetImovel")]

        public ActionResult<List<Imovel>> GetImovel()
        {
            try
            {
                List<Imovel> list = ImovelRepository.GetAll();
                if (list != null) { return Ok(list); }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
