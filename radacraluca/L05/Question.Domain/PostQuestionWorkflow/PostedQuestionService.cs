using System;
using System.Collections.Generic;
using System.Text;
using static Question.Domain.PostQuestionWorkflow.VerifyQuestionDescription;
using LanguageExt.Common;

namespace Tema5Radac.Question.Domain.PostNewQuestionWorkflow
{
    public class PostedQuestionService
    {
        public Result<VerifiedQuestionDescription> PostQuestion(UnverifiedQuestionDescription question)
        {
            
            return new VerifiedQuestionDescription(question.Question, question.Tags);
        }
    }
}
