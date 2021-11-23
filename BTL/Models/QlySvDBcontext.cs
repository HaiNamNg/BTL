using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BTL.Models
{
    public class QlySvDBcontext : DbContext
    {
        public QlySvDBcontext() : base("QlySvDBcontext")
        {
        }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<Khoa> Khoas { get; set; }
        public DbSet<HocPhan> HocPhans { get; set; }
        public DbSet<Account> Accounts { get; set; }
        

        
    }


}
//DESKTOP-GIPHEE4\SQLEXPRESS