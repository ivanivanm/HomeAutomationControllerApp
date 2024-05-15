using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.HelperModels
{
    internal class App
    {
        public App(string name)
        {
            Name = name;
            On = false;
        }

        public App(string name, bool on)
        {
            Name = name;
            On = on;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool On { get; set; } = false;
    }
}
