using Crm.Core.Application.Features.CQRS.Results.MainEntityResults;
using MediatR;
using System;

public class GetContactDetailQuery : IRequest<ContactDetailResult>
{
    public Guid ContactId { get; set; }
    public GetContactDetailQuery(Guid contactId)
    {
        ContactId = contactId;
    }
}
