﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static Question.Domain.PostNewQuestionWorkflow.PostQuestionResult;

namespace Tema5Radac.Question.Domain.PostQuestionWorkflow
{
    public class QuestionVotes
    {
        public QuestionPosted AllQuestionVotes(QuestionPosted question, VoteEnum vote)
        {
            var allQuestionVotes = question.Votes;
            allQuestionVotes.Append(vote);
            return new QuestionPosted(question.QuestionId, question.Title, question.Body, question.Tags, allQuestionVotes.Sum(v => Convert.ToInt32(v)), allQuestionVotes);
        }
    }
}