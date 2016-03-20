using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using Microsoft.Data.Entity;

namespace D05.Models
{
    public class AppSeedData { 
    //public static void Initialize(IServiceProvider serviceProvider, string appPath)
    //{
    //    string relPath = appPath + "//Models//SeedData//";
    //    var context = serviceProvider.GetService<ApplicationDbContext>();
    //        context.Database.Migrate();
    //        if (context.Database == null)
    //    {
    //        throw new Exception("DB is null");
    //    }
    //    if (context.Profile.Any())
    //    {
    //        return;
    //    }


       
    //    context.Transaction.RemoveRange(context.Transaction);
    //    context.Profile.RemoveRange(context.Profile);
    //    context.SaveChanges();

    //        SeedProfilesFromCsv(relPath, context);
    //        SeedTransactionsFromCsv(relPath, context);
    //}
    

    //private static void SeedTransactionsFromCsv(string relPath, ApplicationDbContext context)
    //{
    //    string source = relPath + "Transactions.csv";
    //    if (!File.Exists(source))
    //    {
    //        throw new Exception("Cannot find file " + source);
    //    }
    //    Transaction.ReadAllFromCSV(source);
    //    List<Transaction> lst = Transaction.ReadAllFromCSV(source);
    //    context.Transaction.AddRange(lst.ToArray());
    //        //try { context.SaveChanges(); }
    //        //catch (Exception e)
    //        //{
    //        //    Console.WriteLine("The info is here" + e.StackTrace);
    //        //}
    //        context.SaveChanges();
    //    }

    //private static void SeedProfilesFromCsv(string relPath, ApplicationDbContext context)
    //{
    //    string source = relPath + "Profiles.csv";
    //    if (!File.Exists(source))
    //    {
    //        throw new Exception("Cannot find file " + source);
    //    }
    //    List<Profile> lst = Profile.ReadAllFromCSV(source);
    //    context.Profile.AddRange(lst.ToArray());
    //        //try { context.SaveChanges(); }
    //        //catch(Exception e)
    //        //{
    //        //    Console.WriteLine("The info is here"+e.StackTrace);
    //        //}

    //        context.SaveChanges();

     //   }







}


}




