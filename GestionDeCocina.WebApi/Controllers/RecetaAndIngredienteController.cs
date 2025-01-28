using GestionDeCocina.Application.PaqueteAndReceta.createPaqueteAndReceta;
using GestionDeCocina.Application.RecetaAndIngredientes.createRecetaAndIngredientes;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionDeCocina.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecetaAndIngredienteController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RecetaAndIngredienteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> CreateIngrediente([FromBody] CreateRecetaAndIngredientesCommand command)
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
