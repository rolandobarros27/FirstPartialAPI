using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Models 
{
    public class SubjectModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [MinLength(3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "La ciudad es requerida")]
        [MinLength(3)]
        public string City { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
        public string BirthDay { get; set; }

        [Required(ErrorMessage = "La nacionalidad es requerida")]
        [MinLength(3)]
        public string Country { get; set; }

        [Required(ErrorMessage = "El documento es requerido")]
        public string Ci { get; set; }

        [Required(ErrorMessage = "El id de ciudad es requerida")]
        public int id_city { get; set; }

        [Required(ErrorMessage = "El email es requerido")]
        [MinLength(3)]
        public string Email { get; set; }

        [Required(ErrorMessage = "El telefono es requerido")]
        [MinLength(3)]
        public string Telephone { get; set; }
    }
}

/*
 * 	Id
	IdCiudad
	Nombres
	Apellidos
	Documento
	Telefono
	Email
	FechaNacimiento
	Ciudad
	Nacionalidad

 * 
 **/
