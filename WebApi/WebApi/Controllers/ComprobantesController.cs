using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using WebApi.Models;
using WebApi.Repositories.Interfaces;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprobantesController : ControllerBase
    {
        private IComprobante _comprobante;

        public ComprobantesController(IComprobante comprobante)
        {
            _comprobante = comprobante;
        }

        [HttpGet]
        [Route("Listar")]
        public IActionResult GetAllComprobantes()
        {
            try
            {
                var comprobante = _comprobante.GetAllComprobantes();
                if (comprobante == null)
                {
                    return NotFound();
                }

                return StatusCode(StatusCodes.Status200OK, new { comprobante });

            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status400BadRequest, new { message = e.Message });
            }
        }


        [HttpGet]
        [Route("Obtener/{Id:int}")]
        public IActionResult GetComprobanteById(int Id)
        {
            try
            {
                var comprobante = _comprobante.GetComprobanteById(Id);
                if (comprobante == null)
                {
                    return NotFound();
                }

                return StatusCode(StatusCodes.Status200OK, new { comprobante });

            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status400BadRequest, new { message = e.Message });
            }
        }
    }
}
