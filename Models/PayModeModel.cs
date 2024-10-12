using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class PayModeModel
    {
        // Definicion de propiedas y anotaciones 

        [DisplayName("Pay Mode Id")]//Nombre de la propiedad
        public int Id { get; set; }

        [DisplayName("Pay Mode Name")]//Nombre de la propiedad
        [Required(ErrorMessage = "Pay mode name is required")]//Sera Obligatoria
        [StringLength (50, MinimumLength = 3, ErrorMessage = "Pay mode name must be between 3 and 50 characters")]//Condiciones Minimas 
        public string Name { get; set; }
        [DisplayName ("Pay Mode Observation")]//Nombre de la propiedad
        [Required(ErrorMessage =("Pay mode observation is reqired"))]//Sera Obligatoria
        [StringLength (200, MinimumLength =3, ErrorMessage = ("Pay mode observation must be between 3 and 200 characters"))]//Condiciones Minimas 
        public string Obvservation { get; set; }
    }
}
