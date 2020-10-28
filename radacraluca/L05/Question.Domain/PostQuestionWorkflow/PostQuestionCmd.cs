﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tema5Radac.Question.Domain.PostQuestionWorkflow
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    namespace Question.Domain.CreateQuestionWorkflow
    {
        public struct PostQuestionCmd
        {
            
            public string Title { get; private set; }
           
            public string Body { get; private set; }
           
            public string Tags { get; private set; }

            public PostQuestionCmd(string title, string body, string tags)
            {
                Title = title;
                Body = body;
                Tags = tags;
            }
        }
    }
}
