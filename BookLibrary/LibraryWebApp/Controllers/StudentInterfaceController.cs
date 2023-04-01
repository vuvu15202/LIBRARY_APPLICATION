using ClassLibrary.DAO;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryWebApp.Controllers
{
    public class StudentInterfaceController : Controller
    {
        // GET: StudentInterfaceController
        public ActionResult Home()
        {
            
            ViewBag.bookList = BookDAO.Instance.GetBookList();
            return View();
        }
        public ActionResult History()
        {
            IHttpContextAccessor context = new HttpContextAccessor();
            var historyList = HistoryDAO.Instance.GetBorrowingListByStuID((int)context.HttpContext.Session.GetInt32("accID"));
            ViewBag.accountList = AccountDAO.Instance.GetAccountList();
            ViewBag.HistoryList = historyList;
            return View(historyList);
        }

        public ActionResult Borrow(int bookID)
        {
            
            try
            {
                IHttpContextAccessor context = new HttpContextAccessor();
                var newHis = new History()
                {
                    LibrarianId = 0,
                    StudentId = (int)context.HttpContext.Session.GetInt32("accID"),
                    BookId = bookID,
                    BorrowDate = DateTime.Now,
                };

                HistoryDAO.Instance.InsertHistory(newHis);
            }
            catch (Exception ex)
            {

                throw;
            }
            return RedirectToAction("History", "StudentInterface");
        }

        // GET: StudentInterfaceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentInterfaceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentInterfaceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentInterfaceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentInterfaceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentInterfaceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentInterfaceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
