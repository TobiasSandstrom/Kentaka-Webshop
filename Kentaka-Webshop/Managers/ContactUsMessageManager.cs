using Kentaka_Webshop.Data;
using Kentaka_Webshop.Models.ContactMessageModels;
using Microsoft.EntityFrameworkCore;

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



        public async Task<ContactMessageResult> ChangeToAnsweredAsync(int id)
        {
            var message = await _context.ContactMessages.Where(x => x.Id == id).FirstOrDefaultAsync();
            ContactMessageResult res = new ContactMessageResult();
            if (message == null)
            {
                res.Message = "Cant find message with that id";
                return res;
            }
            if (message.HasBeenAnswered == true)
            {
                res.Message = "Message already marked as answered";
                return res;
            }

            message.HasBeenAnswered = true;
            _context.ContactMessages.Update(message);
            await _context.SaveChangesAsync();

            res.Result = true;
            res.Message = "Message is now marked as answered";
            return res;


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
