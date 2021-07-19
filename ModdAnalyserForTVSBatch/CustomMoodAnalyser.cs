using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModdAnalyserForTVSBatch
{
    public class CustomMoodAnalyserException : Exception
    {
        //Create intance of custom exception type
        ExceptionType type;

        //enum for defining constants
        public enum ExceptionType
        {
            NULL_EXCEPTION, EMPTY_EXCEPTION, CLASS_NOT_FOUND, CONSTRUCTOR_NOT_FOUND, NO_SUCH_METHOD, NULL_MESSAGE, FIELD_NULL
        }

        //parameterized constuctor and alos using base() method
        public CustomMoodAnalyserException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
