using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Primer_parcial.DAL;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;



namespace Primer_parcial.Entidades
{
   public  class Grupos
    {
        [Key]
       
            int GruposId { get; set; }
            string Descripcion { get; set; }
            int Cantidad { get; set; }
            string Grupo { get; set; }
            int Integrantes { get; set; }

        public Grupos()
        {
            GruposId = 0;
            Descripcion = string.Empty;
            Cantidad = 0;
            Grupo = string.Empty;
            Integrantes = 0;
            
        }
    }
}
