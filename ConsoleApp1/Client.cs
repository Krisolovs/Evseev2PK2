using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Client : Person
    {
        public string Email { get; set; }
        public void BookService(OrderedService service)
        {
            Console.WriteLine($"Клиент {Name} отменил запись на услугу {service.Service.Name}");
        }
        public void CancelBooking(OrderedService service)
        {
            Console.WriteLine($"Клиент {Name} отменил запись на услугу {service.Service.Name}.");
        }

    }
}