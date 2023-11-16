using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Abstract;
using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Concrete
{
    public class TeamManager : ITeamService
    {
        private readonly ITeamDAL _teamDAL;

        public TeamManager(ITeamDAL teamDAL)
        {
            _teamDAL = teamDAL;
        }

        public void TDelete(Team entity)
        {
            _teamDAL.Delete(entity);
        }

        public List<Team> TGetActiveTeamList()
        {
            return _teamDAL.GetActiveTeamList();
        }

        public Team TGetByID(int id)
        {
            return _teamDAL.GetByID(id);
        }

        public List<Team> TGetListAll()
        {
            return _teamDAL.GetListAll();
        }

        public void TInsert(Team entity)
        {
            _teamDAL.Insert(entity);
        }

        public void TUpdate(Team entity)
        {
            _teamDAL.Update(entity);
        }
    }
}