using System;

namespace ExercicioException.Entities.Exception
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
