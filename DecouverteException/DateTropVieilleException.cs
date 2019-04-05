using System;
using System.Collections.Generic;
using System.Text;

namespace DecouverteException
{
    public class DateTropVieilleException : Exception
    {
        public DateTropVieilleException(string message) : base(message)
        {
        }
    }
}
