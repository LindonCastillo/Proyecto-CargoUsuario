using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RegistroCompleto.DAL;
using RegistroCompleto.Entidades;
using System.Linq.Expressions;

namespace RegistroCompleto.BLL
{
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios usuario)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Usuario.Add(usuario) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Usuarios Usuario)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(Usuario).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);

            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Usuario.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Usuarios Buscar(int id)
        {
            Contexto db = new Contexto();
            Usuarios Usuario;

            try
            {
                Usuario = db.Usuario.Find(id);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return Usuario;
        }
       
        public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> Usuario)
        {
            List<Usuarios> Lista = new List<Usuarios>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Usuario.Where(Usuario).ToList();
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;

        }
    }
}








