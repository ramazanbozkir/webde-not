using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebdeNot.Models.Views;

namespace WebdeNot.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult getNotes(int userID)
        {
            return Json(DataLogic.Notes.listNote(userID));
        }
        public JsonResult addNote(NoteViews note)
        {
            return Json(DataLogic.Notes.NoteAdd(note));
        }
        public JsonResult deleteNote(int noteID)
        {
            return Json(DataLogic.Notes.DeleteNote(noteID));
        }
        public JsonResult updateNote(NoteViews note)
        {
            return Json(DataLogic.Notes.NoteUpdate(note));
        }
        public JsonResult Login(string nickname,string pass)
        {
            return Json(DataLogic.User.Login(nickname, pass));
        }

        public JsonResult Signup(userView user)
        {
            return Json(DataLogic.User.SignUp(user));
        }
    }
}