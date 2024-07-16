using MessagePack;

namespace TheApp.Models
{
    public class Client : Person
    {
        //[Key]
        public int ClientID { get; set; }
        public Client()
        {

        }
    }
}
