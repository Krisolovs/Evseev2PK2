using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class PriceList
    {
        public List<Service> Services { get; set; } = new List<Service>();

        public void AddService(Service service)
        {
            Services.Add(service);
        }

        public void DisplayPriceList()
        {
            Console.WriteLine("Прайс-лист:");
            foreach (var service in Services)
            {
                Console.WriteLine(service.GetServiceInfo());
            }
        }
    }
}