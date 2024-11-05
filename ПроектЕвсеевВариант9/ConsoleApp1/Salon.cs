using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
        public class Salon
        {
            public PriceList PriceList { get; set; } = new PriceList();
            public List<Client> Clients { get; set; } = new List<Client>();
            public List<Hairdresser> Hairdressers { get; set; } = new List<Hairdresser>();

            public void AddService(Service service)
            {
                PriceList.AddService(service);
            }

            public void DisplayServices()
            {
                PriceList.DisplayPriceList();
            }

            public OrderedService BookService(Client client, Service service, Hairdresser hairdresser)
            {
                var orderedService = new OrderedService
                {
                    Id = 1,
                    Client = client,
                    Service = service,
                    Hairdresser = hairdresser,
                    Date = DateTime.Now,
                    Status = "Запланировано"
                };

                client.BookService(orderedService);
                return orderedService;
            }
        }
}