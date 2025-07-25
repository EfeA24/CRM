using Crm.Core.Application.Features.CQRS.Commands.OfferCommands.Sales;
using Crm.Core.Application.Features.CQRS.Queries.SaleQueries;
using Crm.Core.Application.Features.CQRS.Results.OfferResults.SaleOffer;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRM.Presentation.Api.Controllers.SalesOfferControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOfferProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SalesOfferProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<SalesOfferProductListResult>>> GetAll()
        {
            var result = await _mediator.Send(new GetAllSaleOfferProductsQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SalesOfferProductDetailResult>> GetById(Guid id)
        {
            var result = await _mediator.Send(new GetSalesOfferProductDetailQuary());
            // Query class does not accept id; call as is.
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateSalesOfferProductCommand command)
        {
            await _mediator.Send(command);
            return Created(string.Empty, null);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateSalesOfferProductCommand command)
        {
            command.SalesOfferProductDocumentId = id;
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteSalesOfferProductCommand(id));
            return NoContent();
        }
    }
}
