using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Application.Features.CQRS.Results.DocumentResults.PurchaseDocuments
{
    public class PurchaseOfferProductInfoResult
    {
        public string PurchaseOfferProductName { get; set; }
        public string PurchaseOfferProductType { get; set; }
        public string PurchaseOfferProductPath { get; set; }
    }

}
