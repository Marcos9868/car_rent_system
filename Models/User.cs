using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_rent_system.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string CNH { get; set; }
        public string Expire_Document_Date { get; set; }
    }
}