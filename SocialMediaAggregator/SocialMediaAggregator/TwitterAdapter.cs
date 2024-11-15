using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregator
{
    public class TwitterAdapter : IPlatformAdapter
    {
        public TwitterAPI _twitterAPI;

        public TwitterAdapter(TwitterAPI twitterAPI)
        {
            _twitterAPI = twitterAPI;
        }
        public List<Notification> FetchNotifications()
        {
            return _twitterAPI.FetchNotifications();
        }
        public void MarkAsRead(string notificationId)
        {
            _twitterAPI.MarkNotificationAsRead(notificationId);
        }

        public void DeleteNotification(string notificationId)
        {
            _twitterAPI.DeleteNotification(notificationId);
        }

    }
}
