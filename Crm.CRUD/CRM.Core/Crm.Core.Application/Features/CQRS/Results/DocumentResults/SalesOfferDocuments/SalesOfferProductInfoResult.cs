using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Results.DocumentResults.SalesOfferDocuments
{
    public class SalesOfferProductInfoResult
    {
        public string SalesOfferProductDocumentFileName { get; set; }
        public string SalesOfferProductDocumentFileType { get; set; }
        public string SalesOfferProductDocumentFilePath { get; set; }
    }
}
