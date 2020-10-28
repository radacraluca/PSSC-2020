using Question.Domain.PostNewQuestionWorkflow;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using static Question.Domain.PostNewQuestionWorkflow.PostNewQuestionResult;
using static Question.Domain.PostNewQuestionWorkflow.VerifyQuestionDescription;
using LanguageExt;

namespace Test.App
{
    class Program_Tema5
    {
        static void Main(string[] args)
        {
            List<string> tags = new List<string>()
            {
                "VisualStudio",
              
                "Version"
            };

            var result = UnverifiedQuestionDescription.Create("Why does it appear'?' instead of characters?", tags);

            result.Match(
                Succ: question =>
                {
                    VoteQuestion(question);
                    Console.WriteLine("You can vote this question!");
                    return Unit.Default;
                },
                Fail: ex =>
                {
                    Console.WriteLine($"Question could not be posted. Reason: {ex.Message}");
                    return Unit.Default;
                }
                );
            Console.ReadLine();
        }
        private static void VoteQuestion(UnverifiedQuestionDescription question)
        {
            var verifiedQuestionResult = new PostedQuestionService().PostQuestion(question);
            verifiedQuestionResult.Match(
                    VoteQuestion =>
                    {
                        new VoteService().Vote(VoteQuestion);
                        return Unit.Default;
                    },
                    ex =>
                    {
                        Console.WriteLine("You can't vote this question!");
                        return Unit.Default;
                    }
                );

        }
    }
}