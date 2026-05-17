using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAdvance.designPatterns
{

    public interface INotifiction
    {
        void send();
    }

    public class EmailNotification : INotifiction
    {
        public void send()
        {
            Console.WriteLine("Email sent");
        }
    }

    public class SmsNotification : INotifiction
    {
        public void send()
        {
            Console.WriteLine("SMS sent");
        }
    }

    public class NotificationFactory
    {
        public static INotifiction create(string type)
        {
            return type switch
            {
                "email" => new EmailNotification(),
                "sms" => new SmsNotification(),
                _ => throw new ArgumentException("invelid notifiction")
            };
        }
    }

    public class factoryPattern
    {
        public static void Main()
        {
            INotifiction notifiction = NotificationFactory.create("email");
            notifiction.send();
        }
    }
}
