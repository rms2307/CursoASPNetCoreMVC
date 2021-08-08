using System;

namespace CursoASPNetCoreMVC.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message) { }
    }
}
