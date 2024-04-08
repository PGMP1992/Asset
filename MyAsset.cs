// Added 
using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using static Asset.Utils;

namespace Asset
{
    internal class MyAsset
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int ProductId { get; set; } // Foreign Key 
        public int CountryId { get; set; } // Foreign Key 
        // Objects 
        public Product Product { get; set; }
        public Country Country { get; set; }

        // CRUD Methods

        public bool CheckId(int id, DBCAsset context)
        {
            return (Select(id, context) != null);
        }

        // Select a record
        public MyAsset Select(int id, DBCAsset context)
        {
            MyAsset a = new MyAsset();
            a = context.Assets.FirstOrDefault(x => x.Id == id);
            if (a == null)
            {
                ErrorMsg("Record not Found!");
            }
            return a;
        }

        // Show records in Table
        public void Show(bool byCountry, DBCAsset context)
        {
            string title = "";
            string color = "";
            double lPrice = 0.00;
            List<MyAsset> result;

            // select * from Assets
            //List<MyAsset> result = context.Assets.ToList();

            //Select all from Assets + Product + Countries -----------------------------------------
            if (byCountry) // Order By Country and Date
            {
                result = context.Assets.
                                    Include(x => x.Product).
                                    Include(x => x.Country).
                                    OrderBy(x => x.CountryId).
                                    OrderBy(x => x.PurchaseDate).
                                    ToList();
            } else // order ByDate
            {
                result = context.Assets.
                                    Include(x => x.Product).
                                    Include(x => x.Country).
                                    OrderBy(x => x.PurchaseDate).
                                    ToList();
            }
            
            if (result.Count == 0) {
                ErrorMsg("There are no Assets in the Database");
            
            } else {
                title = "Id".PadRight(8) + 
                        "Type".PadRight(15) +
                        "Brand".PadRight(15) +
                        "Model".PadRight(15) +
                        "Price".PadRight(10) +
                        "Purchase Date".PadRight(22) +
                        "Currency".PadRight(10) +
                        "Local Price".PadRight(10);

                WriteColor("Assets :", "y");
                DrawLine(title);
                WriteColor(title, "g");
                
                foreach (MyAsset p in result) {
                    // calculate local price
                    lPrice = p.Product.Price * p.Country.DollarRate;
                    
                    if (DateTime.Now >= p.PurchaseDate.AddDays((365 * 3) - 180)) { color = "y"; } // 6 months
                    else if (DateTime.Now >= p.PurchaseDate.AddDays(365 * 3 - 90)) { color = "r"; } // 3 months 
                    else { color = "w"; }

                    WriteColor(p.Id.ToString().PadRight(8) +
                                          p.Product.Type.PadRight(15) +
                                          p.Product.Brand.PadRight(15) +
                                          p.Product.Model.PadRight(15) +
                                          p.Product.Price.ToString().PadRight(10) +
                                          p.PurchaseDate.ToString().PadRight(22) +
                                          p.Country.ShortName.PadRight(10) +
                                          lPrice.ToString(), color);
                }
                DrawLine(title);
            } 
        }

        // Add Record 
        public void Add(DateTime dt, int prodId, int countryId, DBCAsset context)
        {
            //MyAsset a = new MyAsset();
            try {
                PurchaseDate = dt;
                ProductId = prodId;
                CountryId = countryId;

                context.Assets.Add(this); // ????????
                context.SaveChanges(); 
                MsgColor("Asset has been Saved");
            
            } catch (Exception e) {
                ErrorMsg(e.Message);
            }
        }

        // Update Record
        public void Update(int id, DateTime dt, int prodId, int countryId, DBCAsset context)
        {
            MyAsset a = Select(id, context);
            if (a != null) {
                try {
                    a.PurchaseDate = dt;
                    a.ProductId = prodId;
                    a.CountryId = countryId;

                    context.Assets.Update(a);
                    context.SaveChanges();
                    MsgColor("Asset has been Updated");
            
                } catch ( Exception e ) {
                    ErrorMsg(e.Message);
                }
            }
            else { 
                ErrorMsg("Record not found!");
            }
        }

        // Delete record
        public void Delete(int id, DBCAsset context)
        {
            MyAsset a = Select(id, context);
            if (a != null) { 
                try {
                    context.Assets.Remove(a);
                    context.SaveChanges();
                    MsgColor("Asset has been Deleted");
                } 
                catch ( Exception e) {
                    ErrorMsg(e.Message);
                }
            }
            else {
                ErrorMsg("Record not found!");
            }
        }
    }
}


