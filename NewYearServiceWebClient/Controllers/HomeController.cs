using NewYearServiceWebClient.NewYearService;
using System;
using System.Web.Mvc;

namespace NewYearServiceWebClient.Controllers
{
    /// <summary>
    /// Контроллер домашних страниц.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Главная страница.
        /// </summary>
        /// <returns>Представление главная страница.</returns>
        public ActionResult Index()
        {
            // Создадим клиент для обращения к службе.
            var client = new NewYearServiceClient();

            // Вызовем метод службы и сохраним результат.
            var result = client.GetDaysToNewYear(DateTime.Now);

            // Помещаем результат в представление.
            ViewBag.DaysToNewYear = result;

            return View();
        }

        /// <summary>
        /// О программе.
        /// </summary>
        /// <returns>Представление о программе.</returns>
        public ActionResult About()
        {
            ViewBag.Message = "Тестовое приложение для работы с WCF в MVC.";

            return View();
        }

        /// <summary>
        /// Контактные данные.
        /// </summary>
        /// <returns>Представление контакты.</returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}