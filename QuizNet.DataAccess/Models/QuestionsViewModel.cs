using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizNet.DataAccess.Models
{
    public class QuestionsViewModel
    {
        public int QID { get; set; }
        public string CONTENT { get; set; }
        public Nullable<int> CORRECT_ANSWER_ID { get; set; }
        public string ANSWER_CONTENT { get; set; }
    }
}
