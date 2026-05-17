using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAdvance.designPatterns
{

    // Design Pattern: Factory Pattern (Creational)
    // Purpose: Create objects without exposing the instantiation logic to the client.
    //          The caller asks for an "email" or "sms" notification and gets the right
    //          implementation back, without knowing the concrete class.
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
        // Renamed from Main to Demo. Call from Program.cs.
        public static void Demo()
        {
            INotifiction notifiction = NotificationFactory.create("email");
            notifiction.send();
        }
    }
}
