using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregator
{
    public class NotificationAggregator
    {
        private List<IPlatformAdapter> _platformAdapters = new List<IPlatformAdapter>();

        public void AddAdapter(IPlatformAdapter adapter)
        {
            _platformAdapters.Add(adapter);
        }

        public List<Notification> FetchAllNotifications()
        {
            List<Notification> notifications = new List<Notification>();
            foreach (var adapter in _platformAdapters)
            {
                notifications.AddRange(adapter.FetchNotifications());
            }
            return notifications;
        }
        public void MarkNotificationAsRead(string notificationId)
        {
            foreach (var adapter in _platformAdapters)
            {
                adapter.MarkAsRead(notificationId);
            }
        }

        public void DeleteNotification(string notificationId)
        {
            foreach (var adapter in _platformAdapters)
            {
                adapter.DeleteNotification(notificationId);
            }
        }
    }
}
