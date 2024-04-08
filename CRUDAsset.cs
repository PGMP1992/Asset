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
            
            // Asset Vars
            int id = 0;
            DateTime dt = Convert.ToDateTime("01-01-2021");
            int iProd = 0;
            int iCountry = 0;

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
                    
                    if (!Empty(sInput))
                    {
                        if (Exit(sInput))
                        {
                            exit = true;
                            validData = false;
                        }
                        try
                        {
                            id = Convert.ToInt32(sInput);
                            newAsset = asset.Select(id, context);
                            break;
                        }
                        catch (Exception)
                        {
                            validData = false;
                            exit = false;
                            MsgInvalidEntry();
                        }
                        break;
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
                    sInput = newAsset.ProductId.ToString();
                    MsgColor("Product Id: " + sInput, "y");
                }

                sInput = CheckStr("Product Id: ", sInput);

                if (!Empty(sInput))
                {
                    if (Exit(sInput))
                    {
                        exit = true;
                        validData = false;
                    }
                    try
                    {
                        iProd = Convert.ToInt32(sInput);
                        break;
                    }
                    catch (Exception)
                    {
                        validData = false;
                        exit = false;
                        MsgInvalidEntry();
                    }
                    break;
                }
            }

            while (!exit)
            {
                country.Show(context); //Show Countries List

                if (update)
                {
                    sInput = newAsset.CountryId.ToString();
                    MsgColor("Country Id: " + sInput, "y");
                }

                Top("Please enter a Country Id from the list:");
                sInput = CheckStr("Country Id: ", sInput);

                if (!Empty(sInput))
                {
                    if (Exit(sInput))
                    {
                        exit = true;
                        validData = false;
                    }
                    try
                    {
                        iCountry = Convert.ToInt32(sInput);
                        break;
                    }
                    catch (Exception)
                    {
                        validData = false;
                        exit = false;
                        MsgInvalidEntry();
                    }
                    break;
                }
            }

            while (!exit)
            {
                if (update)
                {
                    sInput = newAsset.PurchaseDate.ToString();
                    MsgColor("Purchase Date: " + sInput, "y");
                }
                sInput = CheckStr("Purchase Date (DD/MM/YYYY): ", sInput);
                if (!Empty(sInput))
                {
                    if (Exit(sInput))
                    {
                        exit = true;
                        validData = false;
                    }
                    try
                    {
                        dt = Convert.ToDateTime(sInput);
                        break;
                    }
                    catch (Exception)
                    {
                        validData = false;
                        exit = false;
                        MsgInvalidEntry();
                    }
                }
            }

            // Show Imput
            //Console.Write(dt.ToString() + " " + iProd.ToString() + " " + iCountry.ToString());
            if (validData)
            {
                if (!update)
                {
                    asset.Add(dt, iProd, iCountry, context); //Ok
                }
                else
                {
                    asset.Update(id, dt, iProd, iCountry, context);
                }
            }
        } // InputAsset


        public static void DeleteAsset(DBCAsset context)
        {
            bool exit = false;
            string input = "";
            int id = 0;
            MyAsset asset = new MyAsset();
            MyAsset newAsset = new MyAsset();

            while (!exit)
            {
                asset.Show(true, context);
                Top("Please enter an Asset Id from the list:");
                input = CheckStr("Asset Id: ", input);
                if (!Empty(input))
                {
                    if (Exit(input))
                    {
                        exit = true;
                    }
                    try
                    {
                        id = Convert.ToInt32(input);
                        asset.Delete(id, context);
                        break;
                    }
                    catch (Exception)
                    {
                        exit = false;
                        MsgInvalidEntry();
                    }
                    break;
                }
            }
        } // Delete 
    }
}
