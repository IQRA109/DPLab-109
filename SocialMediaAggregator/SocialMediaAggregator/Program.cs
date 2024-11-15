using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwitterAPI twitterAPI = new TwitterAPI();
            FacebookAPI facebookAPI = new FacebookAPI();

            // Set up facade with platform adapters
            NotificationAggregator aggregator = new NotificationAggregator();
            aggregator.AddAdapter(new TwitterAdapter(twitterAPI));
            aggregator.AddAdapter(new FacebookAdapter(facebookAPI));

            // Fetch all notifications
            var notifications = aggregator.FetchAllNotifications();
            foreach (var notification in notifications)
            {
                Console.WriteLine($"[{notification.sourcePlatform}] {notification.Content} (Read: {notification.IsRead})");
            }

            // Mark a notification as read
            aggregator.MarkNotificationAsRead("1");

            // Delete a notification
            aggregator.DeleteNotification("A");
        }
    }
}
    }
}
