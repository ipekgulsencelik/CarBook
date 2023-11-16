using CarBook.DataAccessLayer.Abstract;
using CarBook.DataAccessLayer.Concrete;
using CarBook.DataAccessLayer.Repositories;
using CarBook.EntityLayer.Concrete;

namespace CarBook.DataAccessLayer.EntityFramework
{
    public class EFTeamDAL : GenericRepository<Team>, ITeamDAL
    {
        public List<Team> GetActiveTeamList()
        {
            var context = new CarBookContext();
            var values = context.Teams.Where(x => x.Status == true).ToList();
            return values;
        }
    }
}