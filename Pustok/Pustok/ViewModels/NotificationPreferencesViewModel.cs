namespace Pustok.ViewModels
{
    public class NotificationPreferencesViewModel
    {
        public string UserId { get; set; }
        public bool ReceiveEmailNotifications { get; set; }
        public bool ReceiveSMSNotifications { get; set; }
        public bool ReceivePushNotifications { get; set; }
    }
}
