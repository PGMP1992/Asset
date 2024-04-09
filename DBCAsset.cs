using Microsoft.EntityFrameworkCore;

namespace Asset
{
    internal class DBCAsset : DbContext
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Asset;Integrated Security=True";

        // CreateTables1 - Migration
        public DbSet<Country> Countries { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<MyAsset> Assets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // We tell the app to use the connectionstring.
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            // SeedTables1 - Migration ---------------------------------------------------

            // Table Countries 
            ModelBuilder.Entity<Country>().HasData(new Country { Id = 1, Name = "Sweden", ShortName = "SEK", DollarRate = 0.10 });
            ModelBuilder.Entity<Country>().HasData(new Country { Id = 2, Name = "Spain", ShortName = "EUR", DollarRate = 1.10 });
            ModelBuilder.Entity<Country>().HasData(new Country { Id = 3, Name = "USA", ShortName = "USD", DollarRate = 1.00 });
            ModelBuilder.Entity<Country>().HasData(new Country { Id = 4, Name = "Denmark", ShortName = "DKK", DollarRate = 0.14 });
            ModelBuilder.Entity<Country>().HasData(new Country { Id = 5, Name = "Great Britain", ShortName = "GBP", DollarRate = 1.2 });

            // Products Table 
            ModelBuilder.Entity<Product>().HasData(new Product { Id = 1, Brand = "Apple", Model = "iBook 1.0", Price = 1500.00, Type = "Laptop" });
            ModelBuilder.Entity<Product>().HasData(new Product { Id = 2, Brand = "Apple", Model = "iPhone 8.0", Price = 1000.00, Type = "Phone" });
            ModelBuilder.Entity<Product>().HasData(new Product { Id = 3, Brand = "Samsung", Model = "Galaxy 53", Price = 1500.00, Type = "Phone" });
            ModelBuilder.Entity<Product>().HasData(new Product { Id = 4, Brand = "Samsung", Model = "Pad 8.0", Price = 1000.00, Type = "Tab" });
            ModelBuilder.Entity<Product>().HasData(new Product { Id = 5, Brand = "Google", Model = "Chrome Phone", Price = 1500.00, Type = "Phone" });
            ModelBuilder.Entity<Product>().HasData(new Product { Id = 6, Brand = "Google", Model = "Chrome Book", Price = 1000.00, Type = "Laptop" });

            // Asset Table 
            ModelBuilder.Entity<MyAsset>().HasData(new MyAsset { Id = 1, PurchaseDate = Convert.ToDateTime("01/01/2021"), ProductId = 1, CountryId = 1 });
            ModelBuilder.Entity<MyAsset>().HasData(new MyAsset { Id = 2, PurchaseDate = Convert.ToDateTime("01/03/2021"), ProductId = 2, CountryId = 1 });
            ModelBuilder.Entity<MyAsset>().HasData(new MyAsset { Id = 3, PurchaseDate = Convert.ToDateTime("01/06/2021"), ProductId = 3, CountryId = 1 });
            ModelBuilder.Entity<MyAsset>().HasData(new MyAsset { Id = 4, PurchaseDate = Convert.ToDateTime("01/09/2021"), ProductId = 4, CountryId = 1 });
            ModelBuilder.Entity<MyAsset>().HasData(new MyAsset { Id = 5, PurchaseDate = Convert.ToDateTime("01/12/2021"), ProductId = 5, CountryId = 2 });
            ModelBuilder.Entity<MyAsset>().HasData(new MyAsset { Id = 6, PurchaseDate = Convert.ToDateTime("01/01/2022"), ProductId = 6, CountryId = 2 });
            ModelBuilder.Entity<MyAsset>().HasData(new MyAsset { Id = 7, PurchaseDate = Convert.ToDateTime("01/03/2022"), ProductId = 1, CountryId = 2 });
            ModelBuilder.Entity<MyAsset>().HasData(new MyAsset { Id = 8, PurchaseDate = Convert.ToDateTime("01/06/2022"), ProductId = 2, CountryId = 2 });
            ModelBuilder.Entity<MyAsset>().HasData(new MyAsset { Id = 9, PurchaseDate = Convert.ToDateTime("01/09/2022"), ProductId = 3, CountryId = 3 });
            ModelBuilder.Entity<MyAsset>().HasData(new MyAsset { Id = 10, PurchaseDate = Convert.ToDateTime("01/12/2022"), ProductId = 4, CountryId = 3 });
            ModelBuilder.Entity<MyAsset>().HasData(new MyAsset { Id = 11, PurchaseDate = Convert.ToDateTime("01/01/2021"), ProductId = 1, CountryId = 3 });
            ModelBuilder.Entity<MyAsset>().HasData(new MyAsset { Id = 12, PurchaseDate = Convert.ToDateTime("01/03/2021"), ProductId = 2, CountryId = 4 });
            ModelBuilder.Entity<MyAsset>().HasData(new MyAsset { Id = 13, PurchaseDate = Convert.ToDateTime("01/06/2021"), ProductId = 3, CountryId = 4 });
            ModelBuilder.Entity<MyAsset>().HasData(new MyAsset { Id = 14, PurchaseDate = Convert.ToDateTime("01/09/2021"), ProductId = 4, CountryId = 4 });
            ModelBuilder.Entity<MyAsset>().HasData(new MyAsset { Id = 15, PurchaseDate = Convert.ToDateTime("01/12/2021"), ProductId = 5, CountryId = 4 });
            ModelBuilder.Entity<MyAsset>().HasData(new MyAsset { Id = 16, PurchaseDate = Convert.ToDateTime("01/01/2022"), ProductId = 6, CountryId = 5 });
            ModelBuilder.Entity<MyAsset>().HasData(new MyAsset { Id = 17, PurchaseDate = Convert.ToDateTime("01/03/2022"), ProductId = 1, CountryId = 5 });
            ModelBuilder.Entity<MyAsset>().HasData(new MyAsset { Id = 18, PurchaseDate = Convert.ToDateTime("01/06/2022"), ProductId = 2, CountryId = 5 });
            ModelBuilder.Entity<MyAsset>().HasData(new MyAsset { Id = 19, PurchaseDate = Convert.ToDateTime("01/09/2022"), ProductId = 3, CountryId = 5 });
            ModelBuilder.Entity<MyAsset>().HasData(new MyAsset { Id = 20, PurchaseDate = Convert.ToDateTime("01/12/2022"), ProductId = 4, CountryId = 5 });
        }

    }
}
