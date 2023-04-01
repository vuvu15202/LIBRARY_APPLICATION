using ClassLibrary.DAO;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Web;

namespace LibraryWebApp.Controllers
{
    public class BookManagementController : Controller
    {
        // GET: BookManagementController
        public ActionResult Book()
        {
            var historyList = BookDAO.Instance.GetBookList();
            ViewBag.BookList = historyList;
            return View();
        }


        //[HttpPost]
        //public ActionResult Create(NhanVien nv, HttpPostedFileBase uploadhinh)
        //{


        //    db.NhanVien.Add(nv);

        //    db.SaveChanges();

        //    if (uploadhinh != null && uploadhinh.ContentLength > 0)
        //    {
        //        int id = int.Parse(db.NhanVien.ToList().Last().nhanvien_id.ToString());

        //        string _FileName = "";
        //        int index = uploadhinh.FileName.IndexOf('.');
        //        _FileName = "nv" + id.ToString() + "." + uploadhinh.FileName.Substring(index + 1);
        //        string _path = Path.Combine(Server.MapPath("~/Upload/nhanvien"), _FileName);
        //        uploadhinh.SaveAs(_path);

        //        NhanVien unv = db.NhanVien.FirstOrDefault(x => x.nhanvien_id == id);
        //        unv.hinh = _FileName;
        //        db.SaveChanges();
        //    }


        //    return RedirectToAction("Index");
        //}


        // GET: BookManagementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookManagementController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookManagementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book, IFormFile fileUpload)
        {

            try
            {
                if (fileUpload != null )
                {

                    //string _FileName = "";
                    //_FileName = fileUpload.FileName;
                    //string _path = Path.Combine(IServer.MapPath("~/BookImages/"), _FileName);
                    //fileUpload.SaveAs(_path);

                    //book.Image = _FileName;
                    //BookDAO.Instance.InsertBook(book);
                    string filename = fileUpload.FileName;
                    book.Image = filename;
                    BookDAO.Instance.InsertBook(book);

                    filename = Path.GetFileName(filename);
                    string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot//BookImages", filename);
                    var filePath = Path.GetTempFileName();

                    var stream = new FileStream(uploadPath, FileMode.Create);
                    fileUpload.CopyToAsync(stream);


                }
            }
            catch (Exception)
            {

            }
                
                return RedirectToAction("Book");
        }

        // GET: BookManagementController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var book = BookDAO.Instance.GetBookInfor(id.Value);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: BookManagementController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Book book, IFormFile fileUpload)
        {
            Book bookInfor = BookDAO.Instance.GetBookInfor(book.BookId);
            try
            {
                if (id != book.BookId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    if (fileUpload != null)
                    {

                        string filename = fileUpload.FileName;
                        book.Image = filename;

                        filename = Path.GetFileName(filename);
                        string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot//BookImages", filename);
                        var filePath = Path.GetTempFileName();

                        var stream = new FileStream(uploadPath, FileMode.Create);
                        fileUpload.CopyToAsync(stream);


                    }
                    else if (bookInfor.Image.Length!=0)
                    {
                        book.Image = bookInfor.Image;
                    }
                    else
                    {
                        book.Image = "UnknownImage.jpg";
                    }
                    BookDAO.Instance.UpdateBook(book);
                }
                return RedirectToAction(nameof(Book));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }

           
        }

        // GET: BookManagementController/Delete/5
        public ActionResult Delete(int id)
        {
            using var context = new BookLibrariContext();
            Book e = context.Books.FirstOrDefault(b => b.BookId == id);

            context.Books.Remove(e);

            context.SaveChanges();

            return RedirectToAction("Book", "BookManagement");
        }

        // POST: BookManagementController/Delete/5
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
