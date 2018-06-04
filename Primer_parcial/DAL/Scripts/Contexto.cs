using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Primer_parcial.Entidades;
using System.Data.Entity;


namespace Primer_parcial.DAL.Scripts
{
    public class Contexto : DbContext
    {
        public Dset:<> {Get; Set;}
        public Contexto() : base("ConsStr")
        {}
    }
}
