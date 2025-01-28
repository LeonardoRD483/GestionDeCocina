using GestionDeCocina.Application.Ingredientes.createIngrediente;
using GestionDeCocina.Application.Paquete.createPaquete;
using GestionDeCocina.Application.Paquete.createPaquete.GetPaquete;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionDeCocina.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaqueteController : ControllerBase
    {

        private readonly IMediator _mediator;

        public PaqueteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> CreateIngrediente([FromBody] CreatePaqueteCommand command)
        {
            try
            {
                var id = await _mediator.Send(command);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetItems()
        {
            try
            {
                var result = await _mediator.Send(new GetPaqueteQuery(""));
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
