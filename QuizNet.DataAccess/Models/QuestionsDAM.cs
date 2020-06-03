using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizNet.DataAccess.Models
{
    public class QuestionsDAM
    {
        public int QID { get; set; }
        public string CONTENT { get; set; }
        public List<AnswersDAM> ANSWERS { get; set; }
        public int CORRECT_AID { get; set; }
    }
}
