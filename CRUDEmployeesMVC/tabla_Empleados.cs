
namespace CRUDEmployeesMVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class tabla_Empleados
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El campo 'Nombres' es Obligatorio")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El campo 'Apellidos' es Obligatorio")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El campo 'CI' es Obligatorio")]
        public int CI { get; set; }

        [Required(ErrorMessage = "El campo 'Fecha N.' es Obligatorio")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public System.DateTime Fecha_Nacimiento { get; set; }

        [Required(ErrorMessage = "El campo 'Edad' es Obligatorio")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El campo 'Rol' es Obligatorio")]
        public string Rol { get; set; }

        [Required(ErrorMessage = "El campo 'Salario' es Obligatorio")]
        public decimal Salario { get; set; }
    }
}
