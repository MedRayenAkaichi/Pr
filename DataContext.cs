using Microsoft.EntityFrameworkCore;
using Projet.Entities;
using System.Reflection.Metadata;

namespace Projet.Context
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }

        public virtual DbSet<Depense> Depense { get; set; }
        public virtual DbSet<Revenus> Revenus { get; set; }
        public virtual DbSet<Budget> Budget { get; set; }


    }
}