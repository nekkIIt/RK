using System;
using System.Collections.Generic;
using System.Text;

namespace RealStateAgency
{
    /// <summary>
    /// Клас, що описує об'єкт нерухомості (пропозицію від продавця)
    /// </summary>
    public class Offer
    {
        // ID завжди залишаємо першим (ми його все одно ховаємо)
        public string Id { get; set; } = Guid.NewGuid().ToString();

        // 1. КОНТАКТНІ ДАНІ
        public string OwnerName { get; set; }     // Ім'я продавця
        public string OwnerPhone { get; set; }    // Телефон продавця
        public string OwnerTelegram { get; set; } // Телеграм

        // 2. АДРЕСА
        public string District { get; set; }      // Район
        public string Address { get; set; }       // Адреса (вулиця, будинок)

        // 3. ХАРАКТЕРИСТИКА
        public decimal Price { get; set; }        // Ціна у доларах
        public int Rooms { get; set; }            // Кількість кімнат
        public double Area { get; set; }          // Площа (кв. м)
        public string PropertyType { get; set; }  // Тип (Квартира або Дім)
    }
}
