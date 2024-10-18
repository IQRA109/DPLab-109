using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06__Adapter_pattern
{
    public class SMSNotification: INotification
    {
        public void send(string message, string receiver)
        {
            Console.WriteLine("SMS");
        }
    }
}
