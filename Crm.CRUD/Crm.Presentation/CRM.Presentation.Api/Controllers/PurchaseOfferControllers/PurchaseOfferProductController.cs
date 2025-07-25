using Crm.Core.Application.Features.CQRS.Commands.OfferCommands.Purchase;
using Crm.Core.Application.Features.CQRS.Queries.PurchaseQueries;
using Crm.Core.Application.Features.CQRS.Results.OfferResults.PurchaseOffer;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRM.Presentation.Api.Controllers.PurchaseOfferControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PurchaseOfferProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PurchaseOfferProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<PurchaseOfferProductListResult>>> GetAll()
        {
            var result = await _mediator.Send(new GetAllPurchaseOfferProductsQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseOfferProductDetailResult>> GetById(Guid id)
        {
            var result = await _mediator.Send(new GetPurchaseOfferProductDetailQuery());
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePurchaseOfferProductCommand command)
        {
            await _mediator.Send(command);
            return Created(string.Empty, null);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdatePurchaseOfferProductCommand command)
        {
            command.PurchaseOfferProductId = id;
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeletePurchaseOfferProductCommand(id));
            return NoContent();
        }
    }
}
