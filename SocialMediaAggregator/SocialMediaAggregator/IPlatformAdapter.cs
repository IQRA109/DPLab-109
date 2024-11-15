using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregator
{
     interface IPlatformAdapter
    {
        List<Notification> FetchNotifications();
        void MarkAsRead(string notificationId);
        void DeleteNotification(string notificationId);
    }
}
