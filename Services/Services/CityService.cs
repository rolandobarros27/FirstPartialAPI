using Infraestructure.Models;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CityService
    {
        private CityRepository cityRepository;

        public CityService(string connectionString)
        {
            this.cityRepository = new CityRepository(connectionString);
        }

        public string insert(CityModel city)
        {
            return validateCity(city) ? cityRepository.insert(city) : throw new Exception("Error en la validacion");
        }

        public string modify(CityModel city, int id)
        {
            if (cityRepository.getById(id) == null)
            {
                return validateCity(city) ? cityRepository.modify(city, id) : throw new Exception("Error en la validacion");
            }
            else
            {
                throw new Exception("No se encontro el registro");
            }
        }

        public string delete(int id)
        {
            return cityRepository.delete(id);
        }

        public CityModel getByid(int id)
        {
            return cityRepository.getById(id);
        }

        public IEnumerable<CityModel> read()
        {
            return cityRepository.read();
        }

        private bool validateCity(CityModel city)
        {
            /*if (city.Name.Trim().Length > 2)
            {
                return false;
            }*/

            return true;
        }
    }
}

