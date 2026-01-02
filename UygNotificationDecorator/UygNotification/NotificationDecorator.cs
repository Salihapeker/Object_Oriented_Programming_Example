using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygNotification
{

    // Decorator
    // Notification sınıfından türetilir (IS-A ilişkisi)
    // Aynı zamanda içinde bir Notification referansı tutar (HAS-A ilişkisi)
    internal class NotificationDecorator : Notification
    {
        protected Notification notification;

        // Runtime'da hangi bildirimin sarılacağını belirler
        public void AddNotification(Notification n)
        {
            notification = n;
        }

        public override void Send()
        {
            // ÖNEMLİ:
            // base.Send() çağrılmaz
            // Çünkü Decorator pattern'da zincir,
            // üst sınıf üzerinden değil, içerde tutulan nesne üzerinden kurulur
            notification.Send();
        }

    }
    // Decorator, davranışı kalıtım yerine bileşim (composition) ile genişletir

}
