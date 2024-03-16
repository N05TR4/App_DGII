using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Repositories.Interfaces;


namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContribuyentesController : ControllerBase
    {
        private IContribuyente _contribuyente;

        public ContribuyentesController(IContribuyente contribuyente)
        {
            _contribuyente = contribuyente;
        }

        [HttpGet]
        [Route("Listar")]
        public IActionResult GetAllContribuyentes()
        {

            try
            {
                var contribuyente = _contribuyente.GetAllContribuyentes();
                if (contribuyente == null) {
                    return NotFound();
                }

                return StatusCode(StatusCodes.Status200OK, new { contribuyente });
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status400BadRequest, new { message = e.Message });
            }
        }

        [HttpGet]
        [Route("Obtener/{rncCedula}")]
        public IActionResult GetContribuyenteByRncCedula(string rncCedula)
        {
            try
            {
                var contribuyente = _contribuyente.GetContribuyenteByRncCedula(rncCedula);
                if (contribuyente == null)
                {
                    return NotFound();
                }

                return StatusCode(StatusCodes.Status200OK, new { contribuyente });

            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status400BadRequest, new { message = e.Message });
            }
        }
    }
}
