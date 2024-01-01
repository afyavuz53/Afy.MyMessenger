namespace Afy.MyMessenger.WebMVC.Models
{
    public class MessengerViewModel
    {
        public MessengerViewModel(int s, int r)
        {
            SenderId = s;
            ReceiverId = r;
        }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
    }
}
