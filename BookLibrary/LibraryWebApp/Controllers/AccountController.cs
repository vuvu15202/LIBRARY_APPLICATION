using ClassLibrary.DAO;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryWebApp.Controllers
{
    public class AccountController : Controller
    {
        private IHttpContextAccessor session;
        public ActionResult Login()
        {
            
            return View();
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Login", "Account");
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string txtEmail, string txtPassword)
        {
            Account Acc = AccountDAO.Instance.GetAccByEmailPassword(txtEmail, txtPassword);
           
            if (Acc != null && Acc.Role == 1)
            {
                session = new HttpContextAccessor();
                session.HttpContext.Session.SetInt32("accID", Acc.AccountId);
                return RedirectToAction("History", "LibraryManagement");
            }
            else if (Acc != null && Acc.Role == 2)
            {
                session = new HttpContextAccessor();
                session.HttpContext.Session.SetInt32("accID", Acc.AccountId);
                return RedirectToAction("Home", "StudentInterface");

            }
            else
            {
                ViewBag.Msg = "Invalid input";
                return RedirectToAction("Login", "Account");

            }


        }

    }
}
