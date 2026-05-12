using System;
using System.Collections.Generic;
using System.Text;

namespace RealStateAgency
{
    /// <summary>
    /// Клас, що описує клієнта-покупця та його вимоги до нерухомості (база попиту)
    /// </summary>
    public class Buyer
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string ClientName { get; set; }    // Ім'я покупця
        public string ClientPhone { get; set; }   // Телефон
        public string Telegram { get; set; }      // Нік у Telegram

        public string DesiredDistrict { get; set; } // Бажаний район
        public decimal MaxPrice { get; set; }       // Максимальний бюджет
        public int MinRooms { get; set; }           // Мінімальна кількість кімнат
        public bool WantsHouse { get; set; }        // Шукає дім? (так/ні)
        public bool WantsApartment { get; set; }    // Шукає квартиру? (так/ні)
    }
}
