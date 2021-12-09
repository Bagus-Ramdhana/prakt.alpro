using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace bank.Models
{
    public class dbbank : DbContext
    {   
        public dbbank(DbContextOptions<dbbank> option)
            : base(option){
          }
        public DbSet<nasabah> nasabah { get; set; }
        public DbSet<transaksi> transaksi { get; set; }
        public DbSet<fasilitas> fasilitas { get; set; }
       
       
    }

}