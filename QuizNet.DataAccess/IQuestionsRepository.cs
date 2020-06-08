using System;
using System.Collections.Generic;
using System.Text;
using QuizNet.DataAccess.Models;

namespace QuizNet.DataAccess
{
    public interface IQuestionsRepository
    {
        IEnumerable<Questions> GetAll();
        IEnumerable<Questions> GetById( int id);
    }
}