using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygNotification
{
    internal class Notification
    {
        // Component
        // Tüm bildirim türlerinin temel sınıfı
        // Başlangıçta sistemde sadece Email bildirimi vardır
        public virtual void Send()
        {
            Console.WriteLine("Email gönderildi");

        }
    }
}
