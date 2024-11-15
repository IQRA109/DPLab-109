using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregator
{
    public class TwitterAPI
    {
        public List<TwitterNotification> GetTwitterNotifications() => new List<TwitterNotification>
    {
        new TwitterNotification { Id = "1", Content = "Twitter Notification 1", IsRead = false },
        new TwitterNotification { Id = "2", Content = "Twitter Notification 2", IsRead = false }
    };

        public void MarkNotificationAsRead(string id) => Console.WriteLine($"Twitter notification {id} marked as read.");
        public void DeleteNotification(string id) => Console.WriteLine($"Twitter notification {id} deleted.");
    }
}
