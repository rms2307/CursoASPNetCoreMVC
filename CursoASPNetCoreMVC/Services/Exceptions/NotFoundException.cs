using System;

namespace CursoASPNetCoreMVC.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        { }
    }
}
