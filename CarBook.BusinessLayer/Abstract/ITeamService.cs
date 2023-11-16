using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Abstract
{
    public interface ITeamService : IGenericService<Team>
    {
        List<Team> TGetActiveTeamList();
    }
}