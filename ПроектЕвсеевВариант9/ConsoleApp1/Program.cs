﻿namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Salon salon = new Salon();
            Service haircut = new Service { Id = 1, Name = "Стрижка", Description = "Классическая стрижка", Price = 500 };
            Service coloring = new Service { Id = 2, Name = "Окрашивание", Description = "Полное окрашивание волос", Price = 1500 };
            salon.AddService(haircut);
            salon.AddService(coloring);
            salon.DisplayServices();

            Client client = new Client
            {
                Id = 1,
                Name = "Никита",
                Phone = "89228901201",
                Email = "nikitaproutub@gmail.com"
            };

            
            Hairdresser hairdresser = new Hairdresser
            {
                Id = 1,
                Name = "Александра",
                Specialization = "Парикмахер мужской",
                Experience = 5
            };

           
            OrderedService orderedService = salon.BookService(client, haircut, hairdresser);
            orderedService.Confirm();
            hairdresser.PerformService(orderedService);
        }
    }
}
