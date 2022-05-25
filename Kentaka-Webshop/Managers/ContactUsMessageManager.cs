using Kentaka_Webshop.Data;
using Kentaka_Webshop.Entity;
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

        public async Task<ContactMessageResult> CreateAsync(ContactMessageForm form)
        {
            var message = await _context.ContactMessages.Where(x => x.CategoryName == form.CategoryName && x.Subject == form.Subject && x.UserName == form.UserName && x.UserEmail == form.UserEmail && x.UserMessage == form.UserMessage).FirstOrDefaultAsync();

            ContactMessageResult res = new ContactMessageResult();

            if (message != null)
            {
                res.Message = "You have already sent this mail";
                return res;
            }
            ContactUsMessageEntity newMessage = new ContactUsMessageEntity()
            {
                CategoryName = form.CategoryName,
                Subject = form.Subject,
                UserName = form.UserName,
                UserEmail = form.UserEmail,
                UserMessage = form.UserMessage
            };

            _context.ContactMessages.Add(newMessage);
            await _context.SaveChangesAsync();

            res.Result = true;
            res.Message = "Mail sent succesfully";
            return res;
        }

        public async Task<ContactMessageResult> DeleteAsync(int id)
        {
            var message = await _context.ContactMessages.Where(x => x.Id == id).FirstOrDefaultAsync();
            ContactMessageResult res = new ContactMessageResult();
            if (message == null)
            {
                res.Message = "Cant find message with that id";
                return res;
            }

            _context.ContactMessages.Remove(message);
            await _context.SaveChangesAsync();
            res.Result = true;
            res.Message = "Message removed succesfully";
            return res;
        }

        public async Task<List<ContactMessageViewModel>> GetAllAsync()
        {
            var entityList = await _context.ContactMessages.ToListAsync();
            var messageList = new List<ContactMessageViewModel>();
            foreach (var m in entityList)
            {
                ContactMessageViewModel message = new ContactMessageViewModel()
                {
                    id = m.Id,
                    CategoryName = m.CategoryName,
                    Subject = m.Subject,
                    UserName = m.UserName,
                    UserEmail = m.UserEmail,
                    Message = m.UserMessage,
                    HasBeenAnswered = m.HasBeenAnswered
                };

                messageList.Add(message);
            }

            return messageList;
        }

        public async Task<ContactMessageViewModel> GetOneAsync(int id)
        {
            var messageModel = new ContactMessageViewModel();
            var message = await _context.ContactMessages.Where(x => x.Id == id).FirstOrDefaultAsync();

            if (message == null)
            {
               
                messageModel.id = -1;
                messageModel.CategoryName = String.Empty;
                messageModel.Subject = String.Empty;
                messageModel.UserName = String.Empty;
                messageModel.UserEmail = String.Empty;
                messageModel.Message = String.Empty;
                messageModel.HasBeenAnswered = false;

                return messageModel;
            }

            messageModel.id = message.Id;
            messageModel.CategoryName = message.CategoryName;
            messageModel.Subject = message.Subject;
            messageModel.UserName = message.UserName;
            messageModel.UserEmail = message.UserEmail;
            messageModel.Message = message.UserMessage;
            message.HasBeenAnswered = message.HasBeenAnswered;

            return messageModel;
            
        }
    }
}
