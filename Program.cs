using Microsoft.EntityFrameworkCore;
using System.Net;

namespace EFConcat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contextOptions = new DbContextOptionsBuilder<TestContext>()
                                                                .UseSqlServer("Data Source=DESKTOP-6Q8KE4E\\MSSQLSERVER2022;Integrated Security=SSPI;Initial Catalog=EFConcat;Encrypt=False");

            using (var db = new TestContext(contextOptions.Options))
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                db.Set<City>().Select(itm=>itm.CityName.Concat("- A string")).ToArray();


            }
        }
    }
}
