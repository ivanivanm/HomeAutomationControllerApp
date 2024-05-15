using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.BuilderModels;

namespace DataAccessLayer.MainModel
{
    internal class Home
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Room> Rooms = new List<Room>();

        public Home(string name, List<Room> rooms)
        {
            Name = name;
            Rooms = rooms;
        }

        public Home(string name)
        {
            Name = name;
            Rooms = new List<Room>();
        }
    }
}
