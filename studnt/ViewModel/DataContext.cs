using Microsoft.EntityFrameworkCore;
using studnt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace studnt.ViewModel
{
    public class DataContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //pass the db file
            optionsBuilder.UseSqlite("Data Source = DataBase.db");

            //string connectionString="Server=myse"
        }

        //setting the data base tables
        public DbSet<Instructors> Instructors { get; set; }
        public DbSet<Students> Students { get; set; }

        public DbSet<Modules> Modules { get; set; }

    }
}
