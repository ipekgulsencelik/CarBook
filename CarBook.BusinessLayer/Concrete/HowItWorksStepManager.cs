using CarBook.BusinessLayer.Abstract;
using CarBook.DataAccessLayer.Abstract;
using CarBook.EntityLayer.Concrete;

namespace CarBook.BusinessLayer.Concrete
{
    public class HowItWorksStepManager : IHowItWorksStepService
    {
        private readonly IHowItWorksStepDAL _howItWorksStepDAL;

        public HowItWorksStepManager(IHowItWorksStepDAL howItWorksStepDAL)
        {
            _howItWorksStepDAL = howItWorksStepDAL;
        }

        public void TDelete(HowItWorksStep entity)
        {
            _howItWorksStepDAL.Delete(entity);
        }

        public HowItWorksStep TGetByID(int id)
        {
            return _howItWorksStepDAL.GetByID(id);
        }

        public List<HowItWorksStep> TGetListAll()
        {
            return _howItWorksStepDAL.GetListAll();
        }

        public void TInsert(HowItWorksStep entity)
        {
            _howItWorksStepDAL.Insert(entity);
        }

        public void TUpdate(HowItWorksStep entity)
        {
           _howItWorksStepDAL.Update(entity);
        }
    }
}