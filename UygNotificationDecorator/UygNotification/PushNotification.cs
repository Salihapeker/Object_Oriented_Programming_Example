using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygNotification
{
    internal class PushNotification : NotificationDecorator
    {
        public override void Send()
        {
            base.Send();
            Console.WriteLine("Push notification gönderildi");
        }
    }
    class WhatsAppNotification : NotificationDecorator
    {
        public override void Send()
        {
            base.Send();
            Console.WriteLine("WhatsApp bildirimi gönderildi");
        }
    }
}
