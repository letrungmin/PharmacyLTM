using PharmacyLTM.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyLTM.ViewModels.Common
{
    public class PageResult<T> : PageResultBase
    {
        public List<T> Items { set; get; }
    }
}