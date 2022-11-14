using System;

namespace CarWF.Models
{
    /// <summary>
    /// Сущность Машины
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Гос. Номер
        /// </summary>
        public string GosNumber { get; set; }
        /// <summary>
        /// Машина
        /// </summary>
        public MarkCars Mark { get; set; }
        /// <summary>
        /// Пробег
        /// </summary>
        public decimal Probeg { get; set; }

        /// <summary>
        /// Среднее потребление топлива за час
        /// </summary>
        public decimal AvgFuelForHour { get; set; }
        /// <summary>
        /// Текущий объем топлива
        /// </summary>
        public decimal Fuel { get; set; }
        /// <summary>
        /// Стоимость аренды (за минуту)
        /// </summary>
        public decimal PriseRent { get; set; }
        /// <summary>
        /// Запас Хода
        /// </summary>
        public decimal PowerReserve { get; set; }
        /// <summary>
        /// Сумма Аренды
        /// </summary>
        public decimal RentalAmount { get; set; }

    }
}
