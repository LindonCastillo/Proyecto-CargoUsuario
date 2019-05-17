using System.Data.Entity;
using RegistroCompleto.Entidades;

namespace RegistroCompleto.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuario { get; set; }

        public Contexto() : base("ConStr")
        {        }
    }
}
