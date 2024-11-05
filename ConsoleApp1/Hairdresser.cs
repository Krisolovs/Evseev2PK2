using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
        public class Hairdresser : Person
        {
            public string Specialization { get; set; }
            public int Experience { get; set; } // В годах

            public void PerformService(OrderedService orderedService)
            {
                Console.WriteLine($"{Name} выполняет услугу {orderedService.Service.Name} для клиента {orderedService.Client.Name}.");
            }
        }

  
}