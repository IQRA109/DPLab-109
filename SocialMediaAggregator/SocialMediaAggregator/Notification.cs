using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregator
{
    public class Notification
    {
        public string id;
        public string content;
        public Boolean isRead;
        public string sourceplatform;

        public Notification(string id, string content, Boolean isRead, string sourceplatform)
        {
            this.id = id;
            this.content = content;
            this.isRead = isRead;
            this. sourceplatform = sourceplatform;
        }
    }
}
