using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizNet.DataAccess.Models
{
    public class AnswersDAM
    {
        public int AID { get; set; }
        public string CONTENT { get; set; }
        public Nullable<int> QUESTION_ID { get; set; }

    }
}
