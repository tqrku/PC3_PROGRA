using System;
using System.ComponentModel.DataAnnotations;

namespace PC3_PROGRA.Models
{
    public class Producto
    {
        
        public int ID { get; set; }

        [Required]
        public string name { get; set; } 

        [Required]
        public string picURL { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        public int price { get; set; }

        [Required]
        public string phone { get; set; }

        [Required]
        public string place { get; set; }

        [Required]
        public string userName { get; set; }

        [Required]
        public DateTime addDate { get; set; }
    }
}