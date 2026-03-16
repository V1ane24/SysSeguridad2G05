using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SysSeguridad2G05.EN
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Rol")]
        [Required(ErrorMessage = "Rol es obligatorio")]
        [Display(Name ="Rol")]
        public int IdRol { get; set; }

        [Required(ErrorMessage ="El nombre de usuario es obligatorio")]
        [StringLength(40, ErrorMessage ="Maximo 40 caracteres")]
        [Display(Name ="Nombre Usuario")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido de usuario es obligatorio")]
        [StringLength(40, ErrorMessage = "Maximo 40 caracteres")]
        [Display(Name = "Apellido Usuario")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El Login de usuario es obligatorio")]
        [StringLength(200, ErrorMessage = "Maximo 200 caracteres")]
        [Display(Name = "Login Usuario")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Password de usuario es obligatorio")]
        [StringLength(40, ErrorMessage = "Maximo 40 caracteres")]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage ="Estado es obligatorio")]
        public byte Status { get; set; }

        [Display(Name ="Fecha Registro")]
        public DateTime FechaRegistro { get; set; }
        public Rol Rol { get; set; }
        public int Top_Aux { get; set; }
        public string ConfirmPassword_aux { get; set; }
    }
}
