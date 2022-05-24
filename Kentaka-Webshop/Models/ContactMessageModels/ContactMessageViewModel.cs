namespace Kentaka_Webshop.Models.ContactMessageModels
{
    public class ContactMessageViewModel
    {
        public int id { get; set; }
        public string CategoryName { get; set; }
        public string Subject { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Message { get; set; }
        public bool HasBeenAnswered { get; set; }
    }
}
