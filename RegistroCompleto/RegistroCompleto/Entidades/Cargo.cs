using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace RegistroCompleto.Entidades
{


    public class Cargo
    {
        [Key]
        int CargoId { get; set; }
        string Descripcion { get; set; }

        public Cargo()
        {
            CargoId = 0;
            Descripcion = string.Empty;
        }
    }


}
