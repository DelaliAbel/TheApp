namespace TheApp.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public string MessageDescription { get; set; }
        public string MessageDate { get; set; }
        public string MessageSender { get; set; }
        public string MessageReceiver { get; set; }
        public Message()
        {

        }
    }
}
