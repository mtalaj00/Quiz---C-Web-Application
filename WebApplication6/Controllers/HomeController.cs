using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;
using WebApplication6.Service;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult StartPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult StartPage(UserModel userModel)
        {            
            UsersDAO userDAO = new UsersDAO();
            if (userDAO.FindByUsernameAndPassword(userModel) == true)
            {
                return View("Home",userModel);
            }
            else
            { 
                ModelState.AddModelError("", "Wrong username or password !");
                return View();
            }
        }
        public ActionResult Registration()
        {          
            return View();
        }
        [HttpPost]
        public ActionResult Registration(UserModel userModel)
        {
            UserRegistration userRegistration = new UserRegistration();
            if (userRegistration.SaveUserToDatabase(userModel) == true)
            {
                ModelState.AddModelError("", "Registration Successful !");
            }
            else
            {
                ModelState.AddModelError("", "User with that name already exists !");
            }
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Play()
        {
            QuestionService questionService = new QuestionService();
            QuestionModel questionModel = new QuestionModel();

            questionModel.question = questionService.GetQuestion();
            questionModel.answerA = questionService.GetAnswerA();
            questionModel.answerB = questionService.GetAnswerB();
            questionModel.answerC = questionService.GetAnswerC();
            questionModel.answerD = questionService.GetAnswerD();
            questionModel.correctAnswer = questionService.GetCorectAnswer();

            return View(questionModel);
        }

        [HttpPost]
        public ActionResult Play(string button)
        {

            if (button =="answerA")
            {
                return View("Home");
            }
            else
            {
                return View();
            }
        }
    }
}