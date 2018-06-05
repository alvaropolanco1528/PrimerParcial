using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Primer_parcial.DAL.Scripts;
using Primer_parcial.Entidades;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace Primer_parcial.BLL
{
    public class GruposBll
    {

        public static bool Guardar (Grupos grupos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.grupos.Add(grupos) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
            }

            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static bool Editar(Grupos grupos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(grupos).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }

            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static bool Eliminar (int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Grupos grupos = contexto.grupos.Find(id);

                contexto.grupos.Remove(grupos);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }

            catch (Exception)
            {
                throw;
            }
            return paso;
        }


         public static  Modificar (int id)
        {
            Contexto contexto = new Contexto();
            Grupos grupos = new Grupos();
            try
            {
                grupos = contexto.grupos.Find(id);
                contexto.Dispose();
            }catch(Exception)
            {
                throw;
            }
            return grupos;
        }
    }
}
