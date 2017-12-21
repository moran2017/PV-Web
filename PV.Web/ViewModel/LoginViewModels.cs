using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PV.Web.Models;


namespace PV.Web.ViewModel
{
    public class LoginViewModels
    {

        public String Nombre { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El Codigo no puede estar vacio.")]
        public String Usuario { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El password no puede estar vacio.")]
        public String Password { get; set; }

        public LoginViewModels()
        {

        }
    }
}
}