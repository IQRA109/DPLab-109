using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregator
{
     class FacebookAdapter
    {
        private FacebookAPI _facebookAPI;

        public FacebookAdapter(FacebookAPI facebookAPI)
        {
            _facebookAPI = facebookAPI;
        }

        public List<Notification> FetchNotifications()
        {
            return _facebookAPI.FetchNotifications();
        }
        public void MarkAsRead(string notificationId)
        {
            _facebookAPI.MarkNotificationAsRead(notificationId);
        }

        public void DeleteNotification(string notificationId)
        {
            _facebookAPI.DeleteNotification(notificationId);
        }
    }
}
