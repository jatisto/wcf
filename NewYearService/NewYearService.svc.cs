using System;

namespace NewYearService
{
    /// <summary>
    /// Класс службы реализующий интерфейс взаимодействия со службой.
    /// </summary>
    public class NewYearService : INewYearService
    {
        /// <summary>
        /// Получить  количество времени до нового года от указанной даты.
        /// </summary>
        /// <param name="start">Дата от которой ведется отсчет до нового года.</param>
        /// <returns>Временные промежутки до нового года.</returns>
        public TimeToNewYear GetDaysToNewYear(DateTime start)
        {
            var timeToNewYear = new TimeToNewYear(start);
            return timeToNewYear;
        }
    }
}
