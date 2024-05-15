using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    internal class Fridge
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public bool IsOn { get; set; } = false;
        [Range(-10, 10)]
        public int Temperature { get; set; }
        public bool EnergyEffectiveness { get; set; } = true;

        public bool SmartCooling { get; set; } = true;
    }
}
