using Microsoft.AspNetCore.Mvc;
using QuizNet.BusinessLogic.Interfaces;
using QuizNet.DataAccess;
using QuizNet.DataAccess.Models;
using QuizNet.Models;
using System.Collections.Generic;
using System.Linq;

namespace QuizNet.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionsService _questionsService;
        private readonly IQuizService _quizService;
        QuizNetDataBaseEntities db = new QuizNetDataBaseEntities();

        public QuestionController(IQuestionsService questionService, IQuizService quizService)
        {
            _questionsService = questionService;
            _quizService = quizService;
        }

        public IActionResult GetAll()
        {
            var questions = _questionsService.GetAll();
            return View(questions);
        }

        //public IActionResult Get(int id)
        //{
        //    List<Questions> questionList = db.Questions.ToList();
        //    List<QuestionsViewModel> questionVMList = questionList.Select(x => new QuestionsViewModel
        //    {
        //        QID = x.QID,
        //        CONTENT = x.CONTENT,
        //        ANSWER_CONTENT = x.Answers.CONTENT
        //    }).Where(x => x.QID == id).ToList();

        //    List<Answers> answerList = db.Answers.ToList();
        //    List<AnswersViewModel> answersVMList = answerList.Select(x => new AnswersViewModel
        //    {
        //        AID = x.AID,
        //        CONTENT = x.CONTENT,
        //        QUESTION_ID = x.QUESTION_ID,  
        //    }).Where(x => x.QUESTION_ID == id).ToList();

        //    DetailsViewModel detailsVM = new DetailsViewModel();
        //    detailsVM.QuestionsList = questionVMList;
        //    detailsVM.AnswersList = answersVMList;
       

        //    return View(detailsVM);
        //}

        //    public IActionResult Delete(int id)
        //    {
        //        _questionRepository.Delete(id);
        //        return RedirectToAction("GetAll");
        //    }

        //public IActionResult Create()
        //{
        //    var newQuestion = new QuestionFormViewModel();

        //    return View("QuestionForm", newQuestion);
        //}

        //    public IActionResult Edit(int id)
        //    {
        //        var questionToEdit = _questionRepository.GetById(id);
        //        var viewModel = new QuestionFormViewModel(questionToEdit);

        //        return View("QuestionForm", viewModel);
        //    }

        //    [HttpPost]
        //    public IActionResult Save(QuestionFormViewModel viewModel)
        //    {
        //        if (!ModelState.IsValid)
        //            return View("QuestionForm", viewModel);

        //        var questionToSave = viewModel.GetQuestion();

        //        if (questionToSave.Id != 0)
        //            _questionRepository.Update(questionToSave);
        //        else
        //            _questionRepository.Add(questionToSave);

        //        return RedirectToAction("Get", new { Id = questionToSave.Id });
        //    }

        //    public IActionResult GenerateQuiz()
        //    {
        //        var questions = _quizService.GenerateQuiz();
        //        return View("Quiz", questions);
        //    }
    }
}