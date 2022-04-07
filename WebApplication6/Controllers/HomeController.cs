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
                        
         
            questionService.setId(2);
            questionModel.question = questionService.GetQuestion();
            questionModel.answerA = questionService.GetAnswerA();
            questionModel.answerB = questionService.GetAnswerB();
            questionModel.answerC = questionService.GetAnswerC();
            questionModel.answerD = questionService.GetAnswerD();
            questionModel.correctAnswer = questionService.GetCorectAnswer();

            return View(questionModel);
        }
        [HttpPost]
        public ActionResult Play(String answerA, String answerB, String answerC, String answerD, QuestionModel questionModel)
        {
            if (!string.IsNullOrEmpty(answerA))
            {
                if (questionModel.correctAnswer == questionModel.answerA)
                {
                    
                }
                
                return RedirectToAction("Home");
            }
            else if (!string.IsNullOrEmpty(answerB))
            {
                if (questionModel.correctAnswer == questionModel.answerB)
                {
                  
                }
                
                return RedirectToAction("Play");
            }
            else if (!string.IsNullOrEmpty(answerC))
            {
                if (questionModel.correctAnswer == questionModel.answerC)
                {
                  
                }
                
                return RedirectToAction("Play");
            }
            else if (!string.IsNullOrEmpty(answerD))
            {
                if (questionModel.correctAnswer == questionModel.answerD)
                {
                   
                }
                
                return RedirectToAction("Play");
            }

            return RedirectToAction("Play");
        }
        public ActionResult Leaderboard()
        {           
            return View();
        }

        //[HttpPost]
        //public ActionResult Play(String button)
        //{
        //    if (!String.IsNullOrEmpty(questionModel.answerA))
        //    {
        //        // button 1 clicked
        //        return RedirectToRoute("Home");
        //    }
        //    else
        //        return View();
        //}
    }
}