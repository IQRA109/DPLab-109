using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06__Adapter_pattern
{
    public class _3rdPartyPostalService
    {
        public void sendPostalMail(string address, string city, string zipcode, string message)
        {
            Console.WriteLine("PostalMailsent");
        }
    }
}
