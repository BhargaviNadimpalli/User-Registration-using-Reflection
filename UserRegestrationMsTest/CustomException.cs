using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegestrationMsTest
{
    class CustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_EMAIL,
            INVALID_PASSWORD,
            INVALID_MOBILE
        }
        private ExceptionType type;
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
