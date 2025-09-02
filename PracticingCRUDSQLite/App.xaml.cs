using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
//ADD this
using Microsoft.EntityFrameworkCore.Infrastructure;
namespace PracticingCRUDSQLite
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //this method executes everytime the app startsup
        protected override void OnStartup(StartupEventArgs e)
        {
            //create a database file if it doesnt exist
            DatabaseFacade facade = new DatabaseFacade(new DataContext());
            facade.EnsureCreated();//this method will ensure that the database file is created if it doesnt exist
        }
    }
}
