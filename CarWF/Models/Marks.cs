using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarWF.Models
{    /// <summary>
     /// Перечесление машин
     /// </summary>
    public enum MarkCars
    {
        /// <summary>
        /// Хендай Крета
        /// </summary>
        [Description("Хендай Крета")]
        HyundaiCreta,
        /// <summary>
        /// Лада Веста
        /// </summary>
        [Description("Лада Веста")]
        LadaVesta,
        /// <summary>
        /// Митсубиси Аутлендер
        /// </summary>
        [Description("Митсубиси Аутлендер")]
        MitsubishiOutlander
    }
}
