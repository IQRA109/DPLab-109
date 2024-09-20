using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_sharing_app
{
    public class NotificationService : INotificationService
    {
        public void SendNotification(NotificationType type, string message, User user)
        {
            Console.WriteLine($"Sending {type} to {user.Name} : {message}");
        }
    }
}
