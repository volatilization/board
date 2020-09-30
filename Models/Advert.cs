using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Board.Models
{
    public class Advert
    {
        public enum AdvertType
        {
            [Display(Name = "Покупка")]
            BUY,
            [Display(Name = "Продажа")]
            SELL
        }
        public int AdvertId { get; set; }

        [Display(Name = "Название")]
        public string Title { get; set; }


        [Display(Name = "Тип")]
        public AdvertType AdvType { get; set; }

        [Display(Name = "Текст")]
        public string Body { get; set; }

        [Display(Name = "Телефон")]
        public string Phone { get; set; }
    }
}