using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    internal class AirConditioner
    {
        public AirConditioner(bool isOn, double temperature, Direction airDir, int aCMode, int airSpeed, bool lateStart, bool lateStop, bool turbo, bool selfCleaning)
        {
            IsOn = isOn;
            Temperature = temperature;
            AirDir = airDir;
            ACMode = aCMode;
            AirSpeed = airSpeed;
            LateStart = lateStart;
            LateStop = lateStop;
            Turbo = turbo;
            SelfCleaning = selfCleaning;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public bool IsOn { get; set; } = false;
        [Range(0, 30)]
        public double Temperature { get; set; } = 20;
        public Direction AirDir { get; set; } = Direction.Up;
        [Range(1, 5)]
        public int ACMode { get; set; }
        [Range(1, 10)]
        public int AirSpeed { get; set; }
        public bool LateStart { get; set; } = false;
        public bool LateStop { get; set; } = false;
        public bool Turbo { get; set; } = false;
        public bool SelfCleaning { get; set; } = false;
        public enum Direction
        {
            Up = 1,
            Down = 2,
            Left = 3,
            Right = 4,
        }


    }
}
