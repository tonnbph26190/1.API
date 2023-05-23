using Data.Configurations;
using Data.ModelsClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data.DbContexts
{
    public class CuaHangDbContext : DbContext
    {
        public CuaHangDbContext()
        {

        }
        public CuaHangDbContext(DbContextOptions<CuaHangDbContext> dbContextOptions):base(dbContextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-OJ4UDNH\SQLEXPRESS;Initial Catalog=lap2_DB;Persist Security Info=True;User ID=Nbton03;Password=123"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.ApplyConfiguration(new NhanvienConfiguration());
           
            
        }
        //dbset
        
        public DbSet<NhanVien> NhanViens { get; set; }


    }
}
