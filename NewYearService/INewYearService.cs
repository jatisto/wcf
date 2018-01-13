using System;
using System.ServiceModel;

namespace NewYearService
{
    /// <summary>
    /// Интерфейс, определяющий методы, которые предоставляет служба.
    /// </summary>
    [ServiceContract]
    public interface INewYearService
    {
        /// <summary>
        /// Получить  количество времени до нового года от указанной даты.
        /// </summary>
        /// <param name="start">Дата от которой ведется отсчет до нового года.</param>
        /// <returns>Временные промежутки до нового года.</returns>
        [OperationContract]
        TimeToNewYear GetDaysToNewYear(DateTime start);
    }
}
