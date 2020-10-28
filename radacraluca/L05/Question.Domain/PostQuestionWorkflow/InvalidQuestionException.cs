using System;
using System.Collections.Generic;
using System.Text;

namespace Tema5Radac.Question.Domain.PostQuestionWorkflow
{
    [Serializable]
    public class InvalidQuestionException : Exception
    {
        public InvalidQuestionException()
        { }
        public InvalidQuestionException(string question) : base($"value   can't have more than 1000 characters")
        {

        }
    }
}