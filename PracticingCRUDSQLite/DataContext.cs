using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingCRUDSQLite
{
    public class DataContext:DbContext
    {
        //TO MAP TO OUR DATABASE
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //takes in a string of our data source
            optionsBuilder.UseSqlite("Data Source = UserData.db");
        }

        //since this context class is used to MAP to the database
        //we need to define our table in the database

        public DbSet<User> Users { get; set; }//represents a table in our database called USERS


    }
}
