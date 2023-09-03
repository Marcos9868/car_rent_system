using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using car_rent_system.Models;

namespace car_rent_system.Models
{
    public class Car
    {
        public int Car_Id { get; set; }
        public string Car_Name { get; set; }
        public string Car_Model { get; set; }
        public string Car_Year { get; set; }
        public string Engine { get; set; }
        public string Port_Number { get; set; }
        public string Fuel { get; set; }
        public string Chassi_Number { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public int User_Id { get; set; }

        public User User { get; set; }   
    }
}