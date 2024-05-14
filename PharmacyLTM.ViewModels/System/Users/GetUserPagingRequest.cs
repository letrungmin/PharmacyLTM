using PharmacyLTM.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyLTM.ViewModels.System.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
