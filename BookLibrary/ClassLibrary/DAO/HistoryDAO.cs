using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    public class HistoryDAO
    {
        private static HistoryDAO instance = null;
        private static readonly object instanceLock = new object();
        public HistoryDAO() { }
        public static HistoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new HistoryDAO();

                    }
                    return instance;
                }
            }
        }
        public List<History> GetHistoryList()
        {
            List<History> employees = null;
            try
            {
                using BookLibrariContext context = new BookLibrariContext();
                employees = context.Histories.ToList();
                if(employees == null)
                {
                    employees = new List<History>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return employees;

        }
        public List<History> GetHistoryAscending()
        {
            List<History> employees = null;
            try
            {
                using BookLibrariContext context = new BookLibrariContext();
                //employees = (from t in context.Histories orderby t.BorrowDate descending select t).ToList();
                employees = context.Histories.OrderBy(x => x.BorrowDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return employees;

        }
        public List<History> GetHistoryDescending()
        {
            List<History> employees = null;
            try
            {
                using BookLibrariContext context = new BookLibrariContext();
                employees = context.Histories.OrderByDescending(x => x.BorrowDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return employees;

        }

        public History GetHistoryInforByID(int id)
        {
            var history = new History();
            try
            {
                BookLibrariContext context = new BookLibrariContext();
                history = (context.Histories).FirstOrDefault(a => a.HistoryId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return history;

        }

        public List<History> GetOrderingList()
        {
            var history = new List<History>();
            try
            {
                BookLibrariContext context = new BookLibrariContext();
                history = (context.Histories).Where(p => p.LibrarianId == 0).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return history;

        }
        public List<History> GetBorrowingList()
        {
            var history = new List<History>();
            try
            {
                BookLibrariContext context = new BookLibrariContext();
                history = (context.Histories).Where(p => p.ReturnedDate == null).Where(p => p.LibrarianId != 0).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return history;

        }
        public List<History> GetBorrowingListByStuID(int ID)
        {
            var history = new List<History>();
            try
            {
                BookLibrariContext context = new BookLibrariContext();
                history = (context.Histories).Where(p => p.StudentId == ID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return history;

        }
        public List<History> GetReturnedList()
        {
            var history = new List<History>();
            try
            {
                BookLibrariContext context = new BookLibrariContext();
                history = (context.Histories).Where(p => p.ReturnedDate != null).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return history;

        }

        public List<History> GetOverdueList()
        {
            var history = new List<History>();
            try
            {
                BookLibrariContext context = new BookLibrariContext();
                history = (context.Histories).Where(p => p.ReturnedDate > p.ReturnDeadline).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return history;

        }

        public void InsertHistory(History history)
        {
            try
            {
                using BookLibrariContext context = new BookLibrariContext();
                context.Histories.Add(history);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void UpdateHistory(History history)
        {
            try
            {
                using BookLibrariContext context = new BookLibrariContext();
                context.Entry<History>(history).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //public void DeleteEmployee(Employee employee)
        //{
        //    try
        //    {
        //        using PeFall21B5Context context = new PeFall21B5Context();
        //        var emp = context.Employees.SingleOrDefault(e => e.Id == employee.Id);
        //        context.Employees.Remove(emp);
        //        context.SaveChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

    }
}
