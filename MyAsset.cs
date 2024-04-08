﻿// Added 
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

        // Select a record
        public MyAsset Select(int id, DBCAsset context)
        {
            MyAsset asset1 = new MyAsset();
            asset1 = context.Assets.FirstOrDefault(x => x.Id == id);
            if (asset1 == null)
            {
                MsgColor("Record not Found!", "r");

            }
            return asset1;
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

            //Select all from Assets +Product + Countries -----------------------------------------
            if (byCountry) // Order By Country and Date
            {
                result = context.Assets.
                                    Include(x => x.Product).
                                    Include(x => x.Country).
                                    OrderBy(p => p.CountryId).
                                    OrderBy(p => p.PurchaseDate).
                                    ToList();
            } else // order ByDate
            {
                result = context.Assets.
                                    Include(x => x.Product).
                                    Include(x => x.Country).
                                    OrderBy(p => p.PurchaseDate).
                                    ToList();
            }
            
            if (result.Count == 0) {
                MsgColor("There are no Assets in the Database", "r");
            
            } else {
                title = "Id".PadRight(5) + 
                        "Type".PadRight(15) +
                        "Brand".PadRight(15) +
                        "Model".PadRight(15) +
                        "Price".PadRight(10) +
                        "Purchase Date".PadRight(22) +
                        "Currency".PadRight(10) +
                        "Local Price".PadRight(10);

                MsgColor("Assets :", "y");
                DrawLine(title);
                MsgColor(title, "y");
                
                foreach (MyAsset p in result) {
                    lPrice = p.Product.Price * p.Country.DollarRate;
                    if (DateTime.Now <= PurchaseDate.AddDays((365 * 3) - 180)) { color = "y"; } // 6 months
                    else if (DateTime.Now <= PurchaseDate.AddDays(365 * 3 - 90)) { color = "r"; } // 3 months 
                    else { color = "w"; }

                    Console.WriteLine(p.Id.ToString().PadRight(5) +
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
            try {
                PurchaseDate = dt;
                ProductId = prodId;
                CountryId = countryId;

                context.Assets.Add(this);
                context.SaveChanges(); // this saves to the DB.
                MsgColor("Asset has been Saved", "y");
            } catch (Exception e) {
                MsgColor(e.Message, "r");
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
                    MsgColor("Asset has been Updated", "y");
                    Console.WriteLine("");
                } catch ( Exception e ) {
                    MsgColor(e.Message, "r");
                }
            }
            else { 
                MsgColor("Record not found!", "r");
                Console.WriteLine("");
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
                    MsgColor("Asset has been Deleted", "y");
                    Console.WriteLine("");
                } 
                catch ( Exception e) {
                    MsgColor(e.Message, "r");
                    Console.WriteLine("");
                }
            }
            else {
                MsgColor("Record not found!", "r");
                Console.WriteLine("");
            }
        }

    }
}

