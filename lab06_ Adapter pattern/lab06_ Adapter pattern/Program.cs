using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06__Adapter_pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            INotification emailNotification = new E_mailNotification();
            NotificationSender emailsender = new NotificationSender(emailNotification);
        }
    }
}
