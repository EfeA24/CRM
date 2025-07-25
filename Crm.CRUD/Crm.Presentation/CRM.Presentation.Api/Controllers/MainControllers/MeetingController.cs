using Crm.Core.Application.Features.CQRS.Commands.MainEntityCommands.Meeting;
using Crm.Core.Application.Features.CQRS.Queries.MainEntityQueries;
using Crm.Core.Application.Features.CQRS.Results.MainEntityResults;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRM.Presentation.Api.Controllers.MainControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MeetingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<MeetingListResult>>> GetAll()
        {
            var result = await _mediator.Send(new GetAllMeetingsQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MeetingDetailResult>> GetById(Guid id)
        {
            var result = await _mediator.Send(new GetMeetingDetailQuery(id));
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateMeetingCommand command)
        {
            await _mediator.Send(command);
            return Created(string.Empty, null);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateMeetingCommand command)
        {
            command.MeetingId = id;
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
