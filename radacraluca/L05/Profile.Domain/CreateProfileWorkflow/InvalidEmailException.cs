using System;

namespace Tema5Radac.Profile.Domain.CreateProfileWorkflow
{
    [Serializable]
    public class InvalidEmailException : Exception
    {
        public InvalidEmailException()
        {
        }

        public InvalidEmailException(string email) : base($"Value  is an invalid e-mail format.")
        {
        }

    }
}