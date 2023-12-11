using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсова
{
    public class ErrorBase : Exception
    {
        public ErrorBase(string message) : base(message)
        {
        }


    }
    public class ErrorData : ErrorBase
    {
        public ErrorData() : base("Data ERROR")
        {

        }
    }

    public class ErrorSpelling : ErrorBase
    {
        public ErrorSpelling() : base("No data found. Please check for accuracy")
        {

        }
    }

    public class ErrorAuthentication : ErrorBase
    {
        public ErrorAuthentication() : base("Incorrectly Entered Data")
        {

        }
    }
    public class SecureException : ErrorBase
    {
        public SecureException() : base("\nMake sure it's at least 15 characters " +
                    "OR at least 10 characters including a number, spec symbols and a Upercase letter.")
        {

        }
        
    }
    internal class Exceptions
    {
    }
}
