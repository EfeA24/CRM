using Crm.Core.Application.Features.CQRS.Commands.MainEntityCommands.Company;
using Crm.Core.Application.Features.CQRS.Queries.MainEntityQueries;
using Crm.Core.Application.Features.CQRS.Results.MainEntityResults;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRM.Presentation.Api.Controllers.MainControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CompanyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<CompanyListResult>>> GetAll()
        {
            var result = await _mediator.Send(new GetAllCompaniesQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyDetailResult>> GetById(Guid id)
        {
            var result = await _mediator.Send(new GetCompanyDetailQuery(id));
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCompanyCommand command)
        {
            await _mediator.Send(command);
            return Created(string.Empty, null);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateCompanyCommand command)
        {
            command.CompanyId = id;
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _mediator.Send(new DeleteCompanyCommand(id));
            return NoContent();
        }
    }
}
