using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06__Adapter_pattern
{
    public class PostalMailadapter : INotification
    {
        private readonly _3rdPartyPostalService _postalService;

        public PostalMailadapter( _3rdPartyPostalService postalService )
        {
            this._postalService = postalService;
        }

        public void send(string message, string receiver)
        {
            var parts = receiver.Split(',');

            if(parts.Length == 3)
            {
                string address = parts[0];
                string city = parts[1];
                string zipcode = parts[2];
                
                _postalService.sendPostalMail(address, city, zipcode, message);
            }

            else
            {
                Console.WriteLine("Invalid receiver format for postal mail");
            }
        }
    }
}
