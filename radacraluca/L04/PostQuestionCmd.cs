using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Question.Domain.PostQuestionWorkflow
{
  
    public struct PostQuestionCmd
    {
      
        public string Title { get; private set; }           
        
        public string Body { get; private set; }            
        public string Tags { get; set; }                     
        public PostQuestionCmd(string title, string body, string tags)
        {
            Title = title;
            Body = body;
            Tags = tags;
        }
    }
}