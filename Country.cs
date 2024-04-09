using System.ComponentModel.DataAnnotations;

// Added 
using static Asset.Utils;

namespace Asset
{
    internal class Country
    {
        // Properties
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(5)]
        public string ShortName { get; set; } // Ex. SEK, USD
        public double DollarRate { get; set; } = 0.00;
        //public MyAsset MyAsset { get; set; }

        // Methods -------------------------------------------------------

        // Select a record
        public Country Select(int id, DBCAsset context)
        {
            Country a = new Country();
            a = context.Countries.FirstOrDefault(x => x.Id == id);
            if (a == null)
            {
                ErrorMsg("Country Id does not exist!");
            }
            return a;
        }

        // check Id exits 
        public bool CheckId(int id, DBCAsset context)
        {
            return (Select(id, context) != null);
        }

        // Show All records
        public void Show(DBCAsset context)
        {
            string title;
            string line = "";

            List<Country> Result = context.Countries.ToList();
            title = "Id".PadRight(5) +
                    "Name".PadRight(20) +
                    "Currency".PadRight(15) +
                    "Dollar Rate";

            WriteColor("Countries :", "y");
            DrawLine(title);
            WriteColor(title, "y");

            foreach (Country p in Result)
            {
                Console.WriteLine(p.Id.ToString().PadRight(5) +
                                  p.Name.PadRight(20) +
                                  p.ShortName.PadRight(15) +
                                  p.DollarRate.ToString(), "w");
            }
            DrawLine(title);
        }

        // Add New Record
        public void Add(string name, string shortName, double dollarRate, DBCAsset context)
        {
            Name = name;
            ShortName = shortName;
            DollarRate = dollarRate;

            context.Countries.Add(this);
            context.SaveChanges(); // this saves to the DB.
            MsgColor("Country has been Saved");
        }

        // Update Record
        public void Update(int id, string Name, string ShortName, double DollarRate, DBCAsset context)
        {
            Country c = context.Countries.FirstOrDefault(x => x.Id == id);

            c.Name = Name;
            c.ShortName = ShortName;
            c.DollarRate = DollarRate;

            context.Update(c);
            context.SaveChanges();
            MsgColor("Country has been Updated");
        }

        // Delete Record 
        public void Delete(int id, DBCAsset context)
        {
            Country c = context.Countries.FirstOrDefault(x => x.Id == id);
            context.Remove(c);
            context.SaveChanges();
            MsgColor("Country has been Deleted");
        }
    }
}
