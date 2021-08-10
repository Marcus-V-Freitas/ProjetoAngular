using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAngular.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string DeliveryEstimate { get; set; }

        public float Rating { get; set; }

        public string ImagePath { get; set; }

        public string About { get; set; }

        public string Hours { get; set; }
    }
}
