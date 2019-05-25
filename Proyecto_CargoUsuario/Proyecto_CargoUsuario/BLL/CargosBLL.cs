using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Proyecto_CargoUsuario.DAL;
using Proyecto_CargoUsuario.Entidades;
using System.Linq.Expressions;

namespace Proyecto_CargoUsuario.BLL
{
    class CargosBLL
    {
        public static bool Guardar(Cargos cargos)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Cargo.Add(cargos) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Cargos Cargo)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(Cargo).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);

            }
            catch (Exception)
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
                var eliminar = db.Cargo.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Cargos Buscar(int id)
        {
            Contexto db = new Contexto();
            Cargos Cargo;

            try
            {
                Cargo = db.Cargo.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return Cargo;
        }
        
        public static List<Cargos> GetList(Expression<Func<Cargos, bool>> Cargo)
        {
            List<Cargos> Lista = new List<Cargos>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Cargo.Where(Cargo).ToList();
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
