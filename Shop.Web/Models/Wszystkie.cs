using Shop.Web.Enum;
using System;
using System.ComponentModel.DataAnnotations;


namespace Shop.Web.Models
{
    public class Wszystkie
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }

        [Display(Name = "Data wydania")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data_wydania { get; set; }

        //[DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:0.00}")]
        public decimal Cena { get; set; }
        public string Autor { get; set; }
        public string Wydawnictwo { get; set; }
        public Rodzaj Rodzaj { get; set; }
    }


}