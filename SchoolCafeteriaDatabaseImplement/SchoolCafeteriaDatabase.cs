using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolCafeteriaDatabaseImplement.Models;

namespace SchoolCafeteriaDatabaseImplement
{
    public class SchoolCafeteriaDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=KUGA\SQLEXPRESS;Initial Catalog=SchoolCafeteria;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            }
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Goods> Goods { get; set; }

        public virtual DbSet<GoodsComposition> GoodsCompositions { get; set; }

        public virtual DbSet<TechMapGoods> TechMapGoods { get; set; }

        public virtual DbSet<TechnologicalMap> TechnologicalMaps { get; set; }

        public virtual DbSet<User> Users { get; set; }
    }
}
