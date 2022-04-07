using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }
        public String question { get; set; }
        public String answerA { get; set; }
        public String answerB { get; set; }
        public String answerC { get; set; }
        public String answerD { get; set; }
        public String correctAnswer { get; set; }

    }
}