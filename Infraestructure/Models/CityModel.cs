using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Models
{
    public class CityModel
    {
        public int Id { get; set; }

        public string State { get; set; }

        public string City { get; set; }
    }
}
