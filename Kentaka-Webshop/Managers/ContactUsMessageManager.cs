using Kentaka_Webshop.Data;

namespace Kentaka_Webshop.Managers
{
    public interface IMessageManager
    {
        Task<ContactMessageResult> CreateAsync(ContactMessageForm form);
        Task<ContactMessageResult> ChangeToAnsweredAsync(int id);
        Task<ContactMessageViewModel> GetOneAsync(int id);
        Task<List<ContactMessageViewModel>> GetAllAsync();
        Task<ContactMessageResult> DeleteAsync(int id);

    }
    public class ContactUsMessageManager : IMessageManager
    {
        private readonly SqlDbContext _context;

        public ContactUsMessageManager(SqlDbContext context)
        {
            _context = context;
        }

        public Task<ContactMessageResult> ChangeToAnsweredAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ContactMessageResult> CreateAsync(ContactMessageForm form)
        {
            throw new NotImplementedException();
        }

        public Task<ContactMessageResult> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContactMessageViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ContactMessageViewModel> GetOneAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
