using Microsoft.AspNetCore.Mvc;
using Pustok.ViewModels;

namespace Pustok.Controllers
{
    public class AdminController : Controller
    {

        [HttpPost]
        public IActionResult SendCustomNotification(AdminNotificationViewModel model)
        {
            List<string> recipientIds = model.RecipientIds;
            string notificationMessage = model.Message;

            foreach (var recipientId in recipientIds)
            {
                SendNotificationToUser(recipientId, notificationMessage);
            }

            return RedirectToAction("NotificationSent");
        }

        private void SendNotificationToUser(string recipientId, string notificationMessage)
        {
            throw new NotImplementedException();
        }
    }
}
