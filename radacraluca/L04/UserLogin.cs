using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Question.Domain.PostQuestionWorkflow
{
    /// <summary>
    /// SUM type ProfileId * EmailAdress
    /// </summary>
    public struct UserLogin
    {
        
        public string ProfileId { get; private set; }
        
        public string EmailAdress { get; private set; }

        public UserLogin(string profileId, string emailAdress)
        {
            ProfileId = profileId;
            EmailAdress = emailAdress;
        }
    }
}