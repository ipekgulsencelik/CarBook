using CarBook.EntityLayer.Concrete;

namespace CarBook.DataAccessLayer.Abstract
{
    public interface IMessageDAL : IGenericDAL<Message>
    {
        List<Message> GetInboxList(string session);
        List<Message> GetSendboxList(string session);
        List<Message> GetReadList(string session);
        List<Message> GetUnReadList(string session);
        List<Message> IsDraft(string session);
        List<Message> GetDraftList(string session);
        List<Message> GetTrashList();
        List<Message> GetSpamList(string session);
        List<Message> GetImportantList(string session);
    }
}