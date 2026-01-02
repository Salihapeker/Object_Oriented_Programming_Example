using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygNotification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Temel bildirim
            Notification email = new Notification();

            // Email + SMS
            NotificationDecorator sms = new SMSNotification();
            sms.AddNotification(email);

            // Email + SMS + Push
            NotificationDecorator push = new PushNotification();
            push.AddNotification(sms);

            push.Send();
            // Decorator pattern, nesnelere çalışma zamanında yeni sorumluluklar
            // eklemek için kullanılır ve Open/Closed prensibini destekler.

            //Davranışlar runtime ekleniyorsa
            //Kombinasyonlar dinamikse
            //Mevcut sınıf değişmeyecekse(OCP) decorator kullanılır.
        }
    }
}
