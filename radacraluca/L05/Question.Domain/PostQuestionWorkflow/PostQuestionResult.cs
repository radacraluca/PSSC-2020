using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question.Domain.QuestionWorkflow
{
    [AsChoice]
    public static partial class PostQuestionResult
    {
        public interface IPostQuestionResult
        {
        }

        public class QuestionPosted : IPostQuestionResult
        {
            public Guid IdQuestion { get; private set; }
            public string Title { get; private set; }

            public QuestionPosted(Guid idQuestion, string title)
            {
                IdQuestion = idQuestion;
                Title = title;
            }

        }

        public class QuestionNotPosted : IPostQuestionResult
        {
            public string Reason { get; set; }

            public QuestionNotPosted(string reason)
            {
                Reason = reason;
            }
        }

        public class QuestionValidationFailed : IPostQuestionResult
        {
            public IEnumerable<string> ValidationErrors { get; private set; }

            public QuestionValidationFailed(IEnumerable<string> errors)
            {
                ValidationErrors = errors.AsEnumerable();
            }
        }
    }
}