using System;
using System.Collections.Generic;
using System.Text;
using CSharp.Choices;
using System.Linq;

namespace Question.Domain.QuestionWorkflow
{
    [AsChoice]
    public static partial class QuestionResult
    {
        public interface IQuestionResult { }                
        public class QuestionPosted : IQuestionResult
        {
            public Guid QuestionId { get; private set; }
            public string Title { get; private set; }
            public string Body { get; private set; }
            public string Tags { get; private set; }
            public QuestionPosted(Guid questionId, string title, string body, string tags)
            {
                QuestionId = questionId;
                Title = title;
                Body = body;
                Tags = tags;
            }
        }
        public class QuestionNotPosted : IQuestionResult
        {
            public string Reason { get; set; }

            public QuestionNotPosted(string reason)
            {
                Reason = reason;
            }
        }
        public class QuestionValidationFailed : IQuestionResult          
        {
            public IEnumerable<string> ValidationErrors { get; private set; }

            public QuestionValidationFailed(IEnumerable<string> errors)
            {
                ValidationErrors = errors.AsEnumerable();
            }
        }
    }
}