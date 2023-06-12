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

        public ActionResult<List<TbImovel>> GetImovel()
        {
            try
            {
                List<TbImovel> list = ImovelRepository.GetAll();
                if (list != null) { return Ok(list); }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{Id}", Name = "GetImovelByID")]

        public ActionResult<TbImovel> GetImovelByID(int Id)
        {
            try
            {
                TbImovel _imovel = ImovelRepository.GetByID(Id);
                if (_imovel != null)
                {
                    return Ok(_imovel);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost(Name = "AddImovel")]

        public IActionResult AddImovel([FromBody] TbImovel imovel) //ActionResult<Imovel>
        {
            try
            {
                ImovelRepository.Add(imovel);
                return CreatedAtAction(nameof(GetImovelByID),
                    new { id = imovel.IdImovel },
                    imovel);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete(Name = "DeleteImovel")]

        public ActionResult DeleteImovel(int id)
        {
            try
            {
                var imovel = ImovelRepository.GetByID(id);
                ImovelRepository.Excluir(imovel);
                return Ok();
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
