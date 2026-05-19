using System;
using System.Collections.Generic;
using System.Text;

namespace RealStateAgency
{

    // Клас житла від продавця
    public class Offer
    {
        public string Id { get; set; } = Guid.NewGuid().ToString(); //Айді 

        // КОНТАКТНІ ДАНІ
        public string OwnerName { get; set; }     // Ім'я продавця
        public string OwnerPhone { get; set; }    // Телефон продавця
        public string OwnerTelegram { get; set; } // Телеграм

        // АДРЕСА
        public string District { get; set; }      // Район
        public string Address { get; set; }       // Адреса 

        // ХАРАКТЕРИСТИКА
        public decimal Price { get; set; }        // Ціна у доларах
        public int Rooms { get; set; }            // Кількість кімнат
        public double Area { get; set; }          // Площа (кв. м)

        public double PlotArea { get; set; }       // Площа ділянки 
        public string PropertyType { get; set; }  // Тип (Квартира або Дім)
    }
}
