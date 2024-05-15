using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace DataAccessLayer.BuilderModels
{
    internal class Room
    {
        public Room()
        {
            AirConditioners = new List<AirConditioner>();
            Fridges = new List<Fridge>();
            Lamps = new List<Lamp>();
            TVs = new List<TV>();
        }
        public Room(bool on)
        {
            On = on;

            AirConditioners = new List<AirConditioner>();
            Fridges = new List<Fridge>();
            Lamps = new List<Lamp>();
            TVs = new List<TV>();
        }

        public Room(List<AirConditioner> airConditioners, List<Fridge> fridges, List<Lamp> lamps, List<TV> tVs, bool on)
        {
            AirConditioners = airConditioners;
            Fridges = fridges;
            Lamps = lamps;
            TVs = tVs;
            On = on;
        }

        [Key]
        public int Id { get; set; }
        public List<AirConditioner> AirConditioners { get; set; }
        public List<Fridge> Fridges { get; set; }
        public List<Lamp> Lamps { get; set; }
        public List<TV> TVs { get; set; }

        public bool On { get; set; }
    }
}
