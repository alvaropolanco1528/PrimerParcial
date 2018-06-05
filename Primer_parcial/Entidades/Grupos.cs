using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Primer_parcial.DAL;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using Primer_parcial.DAL.Scripts;


namespace Primer_parcial.Entidades
{
   public  class Grupos
    {
       
            int GrupoId { get; set; }
            string Descripcion { get; set; }
            int Cantidad { get; set; }
            int Grupo { get; set; }
        string Integrantes { get; set; }

        public Grupos()
        {
           GrupoId = 0;
           Descripcion = string.Empty;
            Cantidad = 0;
            Grupo = 0;
            Integrantes = string.Empty;
            
        }
    }
}
