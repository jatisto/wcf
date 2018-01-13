using NewYearServiceCmdClient.NewYearService;
using System;

namespace NewYearServiceCmdClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создадим клиент для обращения к службе.
            var client = new NewYearServiceClient();

            // Вызовем метод службы и сохраним результат.
            var result = client.GetDaysToNewYear(DateTime.Now);

            // Выводим результат на консоль.
            Console.WriteLine($"До нового года осталось {result.Days} дней, или {result.Hours} часов, или {result.Minutes} минут, или {result.Seconds} секунд.");
            Console.ReadKey();
        }
    }
}
