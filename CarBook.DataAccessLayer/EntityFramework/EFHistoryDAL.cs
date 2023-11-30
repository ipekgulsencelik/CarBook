using CarBook.DataAccessLayer.Abstract;
using CarBook.DataAccessLayer.Concrete;
using CarBook.DataAccessLayer.Repositories;
using CarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.DataAccessLayer.EntityFramework
{
    public class EFHistoryDAL : GenericRepository<History>, IHistoryDAL
    {
        public History GetHistory()
        {
            var context = new CarBookContext();
            var value = context.Histories.Where(x => x.Status == true).OrderByDescending(x => x.HistoryID).Take(1).FirstOrDefault();
            return value;
        }

        public void UpdateStatus(History history)
        {
            var context = new CarBookContext();
            if (history.Status == true)
            {
                history.Status = false;
            }
            else
            {
                history.Status = true;
            }
            context.Update(history);
            context.SaveChanges();
        }
    }
}