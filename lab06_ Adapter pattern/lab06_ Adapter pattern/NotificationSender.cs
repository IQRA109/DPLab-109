using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06__Adapter_pattern
{
    public class NotificationSender
    {
        public readonly INotification _notification;

        public NotificationSender(INotification notification)
        {
            _notification = notification;
        }

        public void Notify(string message, string receiver)
        {
            _notification.send(message, receiver);
        }
    }
}
