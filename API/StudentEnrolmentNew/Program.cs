using StudentEnrolmentNew;

namespace StudentEnrolmentWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}



//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using StudentEnrolmentNew.Data;
//using StudentEnrolmentNew.Models;
//using System.IO;

//namespace StudentEnrolmentNew
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var config = new ConfigurationBuilder()
//                .SetBasePath(Directory.GetCurrentDirectory())
//                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
//                .Build();

//            var hello = config.GetConnectionString("DefaultConnection");

//            DatabaseInitializer.CreateDatabase(config.GetConnectionString("DefaultConnection"));

//            // Your code goes here...
//        }
//    }
//    public static class DatabaseInitializer
//    {
//        public static void CreateDatabase(string connectionString)
//        {
//            var optionsBuilder = new DbContextOptionsBuilder<StudentEnrolmentContext>();
//            optionsBuilder.UseMySQL(connectionString);

//            using (var context = new StudentEnrolmentContext(optionsBuilder.Options))
//            {
//                // Applies any pending migrations for the context to the database.
//                // Will create the database if it does not already exist.
//                context.Database.EnsureCreated();
//                // Create a new student
//                var student = new Students("Diego", "Jaumandreu");

//                // Add the student to the DbSet
//                context.Student.Add(student);

//                // Save the changes to the database
//                context.SaveChanges();
//                // Run your seed data function here if necessary
//            }
//        }
//    }

//}




//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddRazorPages();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();

//app.Run();
