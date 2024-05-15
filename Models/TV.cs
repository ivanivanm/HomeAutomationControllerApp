using DataAccessLayer.HelperModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    internal class TV
    {
        public TV()
        {
            Apps.Add(new App("Netflix", false));
            Apps.Add(new App("Spotify", false));
            Apps.Add(new App("Google", false));
            Apps.Add(new App("HBO", false));
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public bool IsOn { get; set; } = false;
        [Range(0, 100)]
        public int LightnessFactor { get; set; } = 50;
        [Range(0, 100)]
        public int Volume { get; set; } = 50;
        public bool NightMode { get; set; } = false;

        private List<App> Apps = new List<App>();
        public void ActivateApp(int appNumber)
        {
            foreach (App app in Apps)
            {
                if (app.Id == appNumber)
                {
                    app.On = true;
                }
            }
        }
        public void DeactivateApp(int appNumber)
        {
            foreach (App app in Apps)
            {
                if (app.Id == appNumber)
                {
                    app.On = false;
                }
            }
        }


    
    }
}
