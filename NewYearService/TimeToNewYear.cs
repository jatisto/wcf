using System;
using System.Runtime.Serialization;

namespace NewYearService
{
    /// <summary>
    /// Класс, содержащий временные промежутки до нового года.
    /// </summary>
    [DataContract]
    public class TimeToNewYear
    {
        /// <summary>
        /// Момент времени, от которого отсчитывается время.
        /// </summary>
        private DateTime _start;

        /// <summary>
        /// Дата нового года.
        /// </summary>
        private DateTime _newYear;

        /// <summary>
        /// Количество дней до нового года.
        /// </summary>
        [DataMember]
        public int Days { get; private set; }

        /// <summary>
        /// Количество часов до нового года.
        /// </summary>
        [DataMember]
        public int Hours { get; private set; }

        /// <summary>
        /// Количество минут до нового года.
        /// </summary>
        [DataMember]
        public int Minutes { get; private set; }

        /// <summary>
        /// Количество секунд до нового года.
        /// </summary>
        [DataMember]
        public int Seconds { get; private set; }

        /// <summary>
        /// Создать новый экземпляр отсчета времени до нового года.
        /// </summary>
        /// <param name="point">Момент времени, от которого ведется отсчет.</param>
        public TimeToNewYear(DateTime point)
        {
            _start = point;
            _newYear = DateTime.Parse($"{point.Year}-12-31 23:59:59.999");
            SetPeriods();
        }

        /// <summary>
        /// Метод устанавливающий временные промежутки до нового года.
        /// </summary>
        private void SetPeriods()
        {
            var interval = _newYear - _start;
            Days = (int)interval.TotalDays;
            Hours = (int)interval.TotalHours;
            Minutes = (int)interval.TotalMinutes;
            Seconds = (int)interval.TotalSeconds;
        }
    }
}