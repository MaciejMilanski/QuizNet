using Microsoft.AspNetCore.Mvc;
using QuizNet.BusinessLogic.Interfaces;
using QuizNet.DataAccess;
using QuizNet.Models;
using System.Collections.Generic;
using System.Linq;

namespace QuizNet.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionsService _questionsService;
        private readonly IQuizService _quizService;

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

        public IActionResult Get(int id)
        {
            var details = _questionsService.GetDetails(id);
            return View(details);
        }

        public IActionResult Create()
        {
            var newQuestion = new QuestionFormViewModel();
            return View("QuestionForm", newQuestion);
        }
        [HttpPost]
        public IActionResult Save(QuestionFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View("QuestionForm", viewModel);

            var question = viewModel.Question;
            var answers = viewModel.Answers;
            answers[viewModel.CorrectAnswerId].IS_CORRECT = true;
            if (question.QID != 0)
            {
                _questionsService.Update(question, answers);
            }
            else
            {
                question = _questionsService.Add(question, answers);
            }

            return RedirectToAction("Get", new { Id = question.QID});
        }
        public IActionResult Delete(int id)
        {
            _questionsService.Delete(id);
            return RedirectToAction("GetAll");
        }


        public IActionResult Edit(int id)
        {
            var questionToEdit = _questionsService.GetDetails(id);
            var viewModel = new QuestionFormViewModel(questionToEdit.QuestionDetails, questionToEdit.AnswersDetails);

            return View("QuestionForm", viewModel);
        }

        public IActionResult GenerateQuiz()
        {
            var quizList = _quizService.GenerateRandomQuiz();
            QuizViewModel quiz = new QuizViewModel(quizList);
            return View("Quiz", quiz);
        }
    }
}