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
    public class PurchaseOfferController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PurchaseOfferController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<PurchaseOfferListResult>>> GetAll()
        {
            var result = await _mediator.Send(new GetAllPurchaseOffersQuery(null));
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseOfferDetailResult>> GetById(Guid id)
        {
            var result = await _mediator.Send(new GetPurchaseOfferDetailQuery(id));
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePurchaseOfferCommand command)
        {
            await _mediator.Send(command);
            return Created(string.Empty, null);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdatePurchaseOfferCommand command)
        {
            command.PurchaseOfferId = id;
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeletePurchaseOfferCommand(id));
            return NoContent();
        }
    }
}
