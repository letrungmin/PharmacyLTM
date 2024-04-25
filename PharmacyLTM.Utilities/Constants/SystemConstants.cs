﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyLTM.Utilities.Constants
{
    public class SystemConstants
    {
        public const string MainConnectionString = "PharmacyLTMDb";

        public class AppSettings
        {
            public const string DefaultLanguageId = "DefaultLanguageId";
            public const string Token = "Token";
            public const string BaseAddress = "BaseAddress";
        }

        public class ProductSettings
        {
            public const int NumberOfFeaturedProducts = 4;
        }
    }
}