using Question.Domain.PostQuestionWorkflow;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using static Question.Domain.PostwQuestionWorkflow.PostQuestionResult;

namespace Test.App
{
    class ProgramQuestion
    {
        static void Main(string[] args)
        {
            var cmd = new PostQuestionCmd("What is the only prime and even number ? ");
            var result = PostQuestion(cmd);
            result.Match(
                    ProcessQuestionPosted,
                    ProcessQuestionNotPosted,
                    ProcessInvalidQuestion
                );

            Console.ReadLine();
        }
        private static IPostQuestionResult ProcessInvalidQuestion(QuestionValidationFailed validationErrors)
        {
            Console.WriteLine("Question validation failed: ");
            foreach (var error in validationErrors.ValidationErrors)
            {
                Console.WriteLine(error);
            }
            return validationErrors;
        }
        private static IPostQuestionResult ProcessQuestionNotPosted(QuestionNotPosted questionNotCreatedResult)
        {
            Console.WriteLine($"Question not posted: {questionNotCreatedResult.Reason}");
            return questionNotCreatedResult;
        }
        private static IPostQuestionResult ProcessQuestionPosted(QuestionPosted question)
        {
            var user = new UserLogin("user1", "user@gmail.com");
            Console.WriteLine($"Question {question.QuestionId}");
            Console.WriteLine($"Confirmation about posting question {user.EmailAdress}");
            return question;
        }
        public static IPostQuestionResult PostQuestion(PostQuestionCmd postQuestionCommand)
        {
            if (string.IsNullOrWhiteSpace(postQuestionCommand.Title))
            {
                return new QuestionNotPosted("Insert a title!");
            }
            if (string.IsNullOrWhiteSpace(postQuestionCommand.Body))
            {
                var errors = new List<string>() { "Invalid description !" };
                return new QuestionValidationFailed(errors);
            }

            var questionId = Guid.NewGuid();
            var result = new QuestionPosted(questionId, postQuestionCommand.Title, postQuestionCommand.Tags, postQuestionCommand.Body);

            return result;
        }
    }
}