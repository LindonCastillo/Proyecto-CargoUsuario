using System.Data.Entity;
using Proyecto_CargoUsuario.Entidades;


namespace Proyecto_CargoUsuario.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Cargos> Cargo { get; set; }

        public Contexto() : base("ConStr")
        {        }
    }
}
