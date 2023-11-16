using CarBook.EntityLayer.Concrete;

namespace CarBook.DataAccessLayer.Abstract
{
    public interface ITeamDAL : IGenericDAL<Team>
    {
        List<Team> GetActiveTeamList();
    }
}