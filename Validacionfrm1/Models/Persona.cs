using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Validacionfrm1.Models
{
    public class Persona
    {
        [Required(ErrorMessage ="EL nombre es obligatorio")]
        [MinLength(10, ErrorMessage ="EL nombre de usuario debe tener al menos 10 caracteres")]

        public String Nombre { get; set; }

        [Range(1, 18, ErrorMessage ="la edad debe estar entre 1 y 18")]

        public int Edad { get; set; }

        [EmailAddress(ErrorMessage ="Debe ingresar un mail valido")]

        public String Email { get; set; }

        [RegularExpression("[MmFf]", ErrorMessage ="Solo puede ingresar una M o F")]

        public String Genero { get; set; }
    }
}