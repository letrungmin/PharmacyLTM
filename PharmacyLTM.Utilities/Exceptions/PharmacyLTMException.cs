using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyLTM.Utilities.Exceptions
{
    public class PharmacyLTMException : Exception
    {
        public PharmacyLTMException() 
        {
        }

        public PharmacyLTMException(string message)
            : base(message) 
        {
        }

        public PharmacyLTMException(string message, Exception inner) 
            : base(message, inner) 
        {
        }
    }
}
