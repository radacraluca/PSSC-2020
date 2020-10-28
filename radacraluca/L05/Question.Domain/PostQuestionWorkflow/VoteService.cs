using LanguageExt.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Question.Domain.PostNewQuestionWorkflow.PostQuestionResult;
using static Question.Domain.PostNewQuestionWorkflow.VerifyQuestionDescription;

namespace Tema5Radac.Question.Domain.PostQuestionWorkflow
{
    public class VoteService
    {
        //verificarea voturilor
        public Task Vote(VerifiedQuestionDescription question)
        {
            return Task.CompletedTask;
        }
    }
}