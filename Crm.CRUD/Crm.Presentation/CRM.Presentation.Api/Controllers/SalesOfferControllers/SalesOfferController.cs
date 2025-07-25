using Crm.Core.Application.Features.CQRS.Commands.OfferCommands.Sales;
using Crm.Core.Application.Features.CQRS.Queries.SaleQueries;
using Crm.Core.Application.Features.CQRS.Results.OfferResults.SaleOffer;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRM.Presentation.Api.Controllers.SalesOfferControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalesOfferController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SalesOfferController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<SalesOfferListResult>>> GetAll()
        {
            var result = await _mediator.Send(new GetAllSaleOffersQuery(null));
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SalesOfferDetailResult>> GetById(Guid id)
        {
            var result = await _mediator.Send(new GetSalesOfferDetailQuary(id));
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateSalesOfferCommand command)
        {
            await _mediator.Send(command);
            return Created(string.Empty, null);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateSalesOfferCommand command)
        {
            command.SalesOfferId = id;
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteSalesOfferCommand(id));
            return NoContent();
        }
    }
}
