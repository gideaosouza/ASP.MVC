using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ValidationAjax.Models
{
    public class ContextoDB : DbContext
    {
        public ContextoDB() : base("DefaultConnection")
        {            
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ContextoDB>());
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties()
               .Where(p => p.Name == p.ReflectedType.Name + "ID")
               .Configure(p => p.IsKey());

            modelBuilder.Configurations.Add(new PessoaMap());
        }

        public System.Data.Entity.DbSet<ValidationAjax.Models.Pessoa> Pessoas { get; set; }

        //public DbSet<Pessoa> Pessoas { get; set; }
    }
    }