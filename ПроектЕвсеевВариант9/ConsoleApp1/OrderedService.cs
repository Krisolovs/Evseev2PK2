using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class OrderedService
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public Service Service { get; set; }
        public Hairdresser Hairdresser { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; } // Запланировано, выполнено, отменено

        public void Confirm()
        {
            Status = "Услуга подтверждена";
            Console.WriteLine($"{Service.Name} подтверждена для клиента {Client.Name}.");
        }

        public void Cancel()
        {
            Status = "Отменено";
            Console.WriteLine($"{Service.Name} отменена для клиента {Client.Name}.");
        }
    }


}
