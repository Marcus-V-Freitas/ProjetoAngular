using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAngular.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public float Rating { get; set; }

        public string Comments { get; set; }

        [ForeignKey(nameof(Restaurant))]
        public int RestaurantId { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
