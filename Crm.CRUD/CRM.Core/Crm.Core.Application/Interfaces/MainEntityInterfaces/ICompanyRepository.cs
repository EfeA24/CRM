using Crm.Core.Application.Interfaces.Generic;
using Crm.Core.Domain.Entities.MainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Interfaces.MainEntityInterfaces
{
    public interface ICompanyRepository : IRepository<Company>
    {
    }
}
