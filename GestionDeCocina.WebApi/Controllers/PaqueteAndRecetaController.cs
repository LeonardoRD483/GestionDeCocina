using GestionDeCocina.Application.Ingredientes.createIngrediente;
using GestionDeCocina.Application.PaqueteAndReceta.createPaqueteAndReceta;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionDeCocina.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaqueteAndRecetaController : ControllerBase
    {

        private readonly IMediator _mediator;

        public PaqueteAndRecetaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> CreateIngrediente([FromBody] CreatePaqueteAndRecetaCommand command)
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
    }
}
