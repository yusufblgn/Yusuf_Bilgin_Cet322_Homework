using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Runtime.ConstrainedExecution;

namespace WebAppCoreMVCCodeFirst._24._03._2023_22.Models
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            //optionBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\work\\2025-2026\\BOUN\\Spring\\week8\\WebAppASPNETCoreCodeFirst_31.03.2023\\cet.mdf;Integrated Security=True;Connect Timeout=30");
            optionBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Cet322Db;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
            //optionBuilder.UseSqlServer("server=DESKTOP-6QAENBR\\MSSQLSERVERCET;database=Education;Integrated Security = True");
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students{ get; set; }

    }
}
