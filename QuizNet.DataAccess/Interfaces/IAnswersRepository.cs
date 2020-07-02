﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizNet.DataAccess
{
    public interface IAnswersRepository
    {
        IEnumerable<Answers> GetByQID(int id);
        void AddAnswers(List<Answers> answers);
        void UpdateAnswers(List<Answers> answers, int questionId);
        void Delete(int id);
    }
}