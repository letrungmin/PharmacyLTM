﻿using PharmacyLTM.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyLTM.ViewModels.System.Users
{
    public class RoleAssignRequest
    {
        public Guid Id { get; set; }
        public List<SelectItem> Roles { get; set; } = new List<SelectItem>();
    }
}