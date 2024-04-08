// Added
using static Asset.Utils;

namespace Asset
{
    internal class CRUDAsset
    {
        public static void InputAsset(bool update, DBCAsset context)
        {
            bool exit = false,
                 validData = true;
            string sInput = "";
            int id = 0;
            int iProd = 0;
            int iCountry = 0;
            DateTime dt = Convert.ToDateTime("01-01-2021");
            
            MyAsset asset = new MyAsset();
            MyAsset newAsset = new MyAsset();
            Product prod = new Product();
            Country country = new Country();

            if (update)   
            {
                while (!exit)
                {
                    asset.Show(true, context);
                    Top("Please enter an Asset Id from the list:");
                    sInput = CheckStr("Asset Id: ", sInput);
                    
                    if (!Empty(sInput) && Exit(sInput))
                    {
                        exit = true;
                        validData = false;
                        break;
                    }

                    try
                    {
                        id = Convert.ToInt32(sInput);
                        // Check Id exists 
                        if (asset.CheckId(id, context))
                        {
                            validData = true;
                            break;
                        }
                        else
                        {
                            validData = false;
                        }
                    }
                    catch (Exception e)
                    {
                        validData = false;
                        MsgColor(e.Message);
                    }
                }
            }

            while (!exit)
            {
                // Input Assets 
                prod.Show(context); //Show Products List

                Top("Please enter a Product Id from the list:");
                
                if (update) //Show Product
                {
                    //sInput = newAsset.ProductId.ToString();
                    //sInput = asset.ProductId.ToString();
                    //WriteColor("Product Id: " + sInput, "y");
                }

                sInput = CheckStr("Product Id: ", sInput);

                if (!Empty(sInput) && Exit(sInput) )
                {
                    exit = true;
                    validData = false;
                    break;
                }
                
                try
                {
                    iProd = Convert.ToInt32(sInput);
                    validData = true;
                    // Check ProdId exists  
                    break;
                }
                catch (Exception e)
                {
                    validData = false;
                    MsgColor(e.Message);
                }
            }

            while (!exit)
            {
                country.Show(context); //Show Countries List

                if (update)
                {
                    //sInput = newAsset.CountryId.ToString();
                    //sInput = asset.CountryId.ToString();
                    //WriteColor("Country Id: " + sInput, "y");
                }

                Top("Please enter a Country Id from the list:");
                sInput = CheckStr("Country Id: ", sInput);

                if (!Empty(sInput) && Exit(sInput))
                {
                    exit = true;
                    validData = false;
                    break;
                }
                try
                {
                    iCountry = Convert.ToInt32(sInput);
                    validData = true;
                    // Check countryId 
                    break;
                }
                catch (Exception e)
                {
                    validData = false;
                    MsgColor(e.Message);
                }
            }

            while (!exit)
            {
                if (update)
                {
                    //sInput = asset.PurchaseDate.ToString();
                    //WriteColor("Purchase Date: " + sInput, "y");
                }

                sInput = CheckStr("Purchase Date (DD/MM/YYYY): ", sInput);
                if (!Empty(sInput) && Exit(sInput))
                {
                    exit = true;
                    validData = false;
                    break;
                }
                
                try
                {
                    dt = Convert.ToDateTime(sInput);
                    validData = true;
                    break;
                }
                catch (Exception e)
                {
                    validData = false;
                    MsgColor(e.Message);
                }
            }

            if (validData)
            {
                if (!update)
                {
                    // Add new record 
                    newAsset.Add(dt, iProd, iCountry, context);
                }
                else
                {
                    // Update
                    newAsset.Update(id, dt, iProd, iCountry, context); // Works
                }
            }
        } // InputAsset


        public static void DeleteAsset(DBCAsset context)
        {
            bool exit = false;
            string input = "";
            int id = 0;
            MyAsset asset = new MyAsset();

            while (!exit)
            {
                asset.Show(true, context);
                Top("Please enter an Asset Id from the list:");
                input = CheckStr("Asset Id: ", input);
                if (!Empty(input) && Exit(input))
                {
                    exit = true;
                    break;
                }

                try
                {
                    id = Convert.ToInt32(input);
                    if (asset.CheckId(id, context))
                    {
                        asset.Delete(id, context); //Works 
                        break;
                    }
                }
                catch (Exception e)
                {
                    exit = false;
                    MsgColor(e.Message);
                }
            }
        } // Delete 
    }
}
