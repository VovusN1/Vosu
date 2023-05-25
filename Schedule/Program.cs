using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Schedule.Context;

namespace Schedule
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        //private const string connectionString = "Data Source=HOMIE;Initial Catalog = MaybeMyTable;Trusted_Connection=True;Encrypt=False;";
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            //SqlConnection connection = new SqlConnection(connectionString);
            //ConfigureServices();
        }
        //public static IServiceProvider _serviceProvider;
        //static void ConfigureServices()
        //{
        //    //string connection = "Data Source=.\\SQLEXPRESS;Initial Catalog=myTable3;Integrated Security=True";
        //    string connectionString = "Data Source=HOMIE;Initial Catalog = MaybeMyTable;Trusted_Connection=True;Encrypt=False;";
        //    var services = new ServiceCollection();
        //    services.AddDbContext<MainContext>(option =>
        //    {
        //        option.UseSqlServer(connectionString);
        //        option.EnableSensitiveDataLogging(true);
        //    });
        //    _serviceProvider = services.BuildServiceProvider();
        //}

    }
}