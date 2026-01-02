using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygNotification
{
    // Concrete Decorator
    // Sisteme SMS bildirim davranışını ekler
    internal class SMSNotification : NotificationDecorator
    {
        public override void Send()
        {
            // Önce kendisinden önce eklenen bildirimi çalıştırır
            base.Send();
            // Ardından kendi davranışını ekler
            Console.WriteLine("SMS gönderildi. ");
        }
    }
}
