using ECommercePrototypeEnjo.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercePrototypeEnjo.Data
{
    public class ECommerceEnjoContext : DbContext, IDbContext
    {
        public ECommerceEnjoContext()
      : base("name=ECommerceEnjoConnectionString")
        {
#if DEBUG
            //Database.Log = new Action<string>(s =>
            //{
            //    string str = s.Length > 32766 ? s.Substring(0, 30000) : s;
            //    System.Diagnostics.Debug.WriteLine("{0}", (object)str);
            //});

            Database.SetInitializer<ECommerceEnjoContext>(new CreateDatabaseIfNotExists<ECommerceEnjoContext>());
#else
             Database.SetInitializer<ECommerceEnjoContext>(new NullDatabaseInitializer<ECommerceEnjoContext>());
#endif
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
