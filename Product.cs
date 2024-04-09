using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing;



// Added
using static Asset.Utils;

namespace Asset
{
    internal class Product
    {
        //Properties
        public int Id { get; set; }
        [MaxLength(100)]
        public string Brand { get; set; }
        [MaxLength(100)]
        public string Model { get; set; }
        public double Price { get; set; } = 0.00;
        [MaxLength(100)]
        public string Type { get; set; }
        //public MyAsset MyAsset { get; set; }
        
        // Methods

        // Select a record
        public Product Select(int id, DBCAsset context)
        {
            Product a = new Product();
            a = context.Products.FirstOrDefault(x => x.Id == id);
            if (a == null)
            {
                ErrorMsg("Product Id does not exist!");
            }
            return a;
        }

        // check Id exits 
        public bool CheckId(int id, DBCAsset context)
        {
            return (Select(id, context) != null);
        }

        // Show Records
        public void Show(DBCAsset context)
        {
            string title = "";
            string line = "";
            List<Product> Result = context.Products.ToList();
            title = "Id".PadRight(5) +
                    "Type".PadRight(10) +
                    "Brand".PadRight(10) +
                    "Model".PadRight(20) +
                    "Price".PadRight(10) ;

            WriteColor("Products :", "y");
            DrawLine(title);
            WriteColor(title, "g");

            foreach (Product p in Result)
            {
                Console.WriteLine(p.Id.ToString().PadRight(5) +
                                  p.Type.PadRight(10) +
                                  p.Brand.PadRight(10) +
                                  p.Model.PadRight(20) +
                                  //p.Price.ToString().PadRight(10), "w");
                                  String.Format("{0:###,###}", p.Price) ,"w");
            }
            DrawLine(title);
        }

        public void Add(string type, string brand, string model, double price, DBCAsset context)
        {
            Type = type;
            Brand = brand;
            Model = model;
            Price = price;

            context.Products.Add(this);
            context.SaveChanges(); // this saves to the DB.
            MsgColor("Product has been Saved");
        }

        public void Update(int id, string type, string brand, string model, double price, DBCAsset context)
        {
            Product p = context.Products.FirstOrDefault(x => x.Id == id);

            p.Type = type;
            p.Brand = brand;
            p.Model = model;
            p.Price = price;

            context.Update(p);
            context.SaveChanges();
            MsgColor("Product has been Updated");
        }

        public void Delete(int id, DBCAsset context)
        {
            Product p = context.Products.FirstOrDefault(x => x.Id == id);
            context.Remove(p);
            context.SaveChanges();
            MsgColor("Product has been Deleted");
        }
    }
}
