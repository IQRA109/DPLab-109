using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregator
{
    public class FacebookAPI
    {
        public List<FacebookNotification> GetFacebookNotifications() => new List<FacebookNotification>
    {
        new FacebookNotification { Id = "A", Content = "Facebook Notification A", IsRead = false },
        new FacebookNotification { Id = "B", Content = "Facebook Notification B", IsRead = false }
    };

        public void MarkNotificationAsRead(string id) => Console.WriteLine($"Facebook notification {id} marked as read.");
        public void DeleteNotification(string id) => Console.WriteLine($"Facebook notification {id} deleted.");
    }
}
