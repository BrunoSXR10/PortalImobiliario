using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portal.BLL;
using Portal.MODEL;

namespace Portal.BLLService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorretorController : ControllerBase
    {

        [HttpGet("{Id}", Name = "GetCorretorByID")]

        public ActionResult<Usuario> GetCorretorByID(int Id)
        {
            try
            {
                Usuario _corretor = CorretorRepository.GetByID(Id);
                if (_corretor != null)
                {
                    return Ok(_corretor);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{cpf}", Name = "GetCorretorByCPF")]

        public ActionResult<Usuario> GetCorretorByCPF(string cpf)
        {
            try
            {
                Usuario _corretor = CorretorRepository.GetByCpf(cpf);
                if(_corretor != null)
                {
                    return Ok(_corretor);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }



        [HttpPost(Name = "AddCorretor")]
        public IActionResult AddCorretor([FromBody] Usuario corretor) //ActionResult<Imovel>
        {
            try
            {
                CorretorRepository.Add(corretor);
                return CreatedAtAction(nameof(GetCorretorByID),
                    new { id = corretor.Id },
                    corretor);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
