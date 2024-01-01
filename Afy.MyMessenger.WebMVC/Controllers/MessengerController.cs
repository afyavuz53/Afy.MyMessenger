using Afy.MyMessenger.WebMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Afy.MyMessenger.WebMVC.Controllers
{
    public class MessengerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2(int senderid, int receiverid)
        {
            return View(new MessengerViewModel(senderid, receiverid));
        }

        public IActionResult MessengerUser()
        {
            return View();
        }
    }
}
