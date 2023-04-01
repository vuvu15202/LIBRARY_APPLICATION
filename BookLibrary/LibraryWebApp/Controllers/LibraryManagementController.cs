using ClassLibrary.DAO;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryWebApp.Controllers
{
    public class LibraryManagementController : Controller
    {
        // GET: LibraryManagementController
        public ActionResult History()
        {
            
            var historyList = HistoryDAO.Instance.GetHistoryList();
            ViewBag.accountList = AccountDAO.Instance.GetAccountList();
            ViewBag.HistoryList = historyList;
            return View(historyList);
        }
        public ActionResult Home()
        {

            
            return View();
        }

        // GET: LibraryManagementController/Details/5
        public ActionResult Detail(int id)
        {
            var history = HistoryDAO.Instance.GetHistoryInforByID(id);
            ViewBag.history = history;
            return View(history);
        }

        // GET: LibraryManagementController/Create
        public ActionResult Create()
        {
            IHttpContextAccessor context = new HttpContextAccessor();
            History his = new History();
            his.LibrarianId = context.HttpContext.Session.GetInt32("accID");
            his.BorrowDate = DateTime.Now;
            his.ReturnDeadline = (DateTime.Now).AddDays(7);
            return View(his);
        }

        // POST: LibraryManagementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(History history)
        {
            try
            {
               
                HistoryDAO.Instance.InsertHistory(history);
               
                
            }
            catch (Exception ex)
            {
                
            }
            return RedirectToAction("History");
        }

        public ActionResult Borrowed(int id)
        {
            IHttpContextAccessor context = new HttpContextAccessor();
            History his = HistoryDAO.Instance.GetHistoryInforByID(id);
            his.BorrowDate = DateTime.Now;
            his.ReturnDeadline = (DateTime.Now).AddDays(7);
            his.LibrarianId = context.HttpContext.Session.GetInt32("accID");
            HistoryDAO.Instance.UpdateHistory(his);
            return RedirectToAction("History", "LibraryManagement");
        }
        public ActionResult Returned(int id)
        {
            IHttpContextAccessor context = new HttpContextAccessor();
            History his = HistoryDAO.Instance.GetHistoryInforByID(id);
            his.ReturnedDate = DateTime.Now;
            HistoryDAO.Instance.UpdateHistory(his);
            return RedirectToAction("History", "LibraryManagement");
        }

        // GET: LibraryManagementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LibraryManagementController/Edit/5
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

        // GET: LibraryManagementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LibraryManagementController/Delete/5
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

        public ActionResult Filter(int mode)
        {
            ViewBag.accountList = AccountDAO.Instance.GetAccountList();
            switch (mode)
            {
                case 1:
                    var historyList = HistoryDAO.Instance.GetOrderingList();
                    ViewBag.historyList = historyList;
                    //return RedirectToAction("Filter", "LibraryManagement");
                    break;
                case 2:
                    ViewBag.historyList = HistoryDAO.Instance.GetBorrowingList();
                    break;
                case 3:
                    ViewBag.historyList = HistoryDAO.Instance.GetOverdueList();
                    break;
                case 4:
                    ViewBag.historyList = HistoryDAO.Instance.GetReturnedList();
                    break;
                case 5:
                    ViewBag.historyList = HistoryDAO.Instance.GetHistoryList();
                    break;
                case 6:
                    ViewBag.historyList = HistoryDAO.Instance.GetHistoryAscending();
                    break;
                case 7:
                    ViewBag.historyList = HistoryDAO.Instance.GetHistoryDescending();
                    break;

                default:
                    ViewBag.historyList = HistoryDAO.Instance.GetHistoryList();
                    break;
            }
            //return RedirectToAction("History", "LibraryManagement");
            return View();
        }
    }
}
