using Microsoft.EntityFrameworkCore;

namespace EFConcat
{
    public class TestContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected TestContext(DbContextOptions options)
        : base(options)
        {
        }
        public TestContext(DbContextOptions<TestContext> options)
        : base(options)
        {
        }
        public TestContext()
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<City>().HasKey(itm => itm.CityID);
        }

    }



    public class City
    {
        public Guid CityID { get; set; }
        public string CityName { get; set; }
        

    }



}