using System;

namespace TrabalhandoComExcecoes.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message): base(message)
        {
        }
    }
}
