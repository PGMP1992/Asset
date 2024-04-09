// Added
using Asset;
using Microsoft.EntityFrameworkCore;
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
            int productId = 0;
            int countryId = 0;
            DateTime dt = Convert.ToDateTime("01-01-2021");

            MyAsset asset = new MyAsset();
            MyAsset newAsset = new MyAsset();
            Product product = new Product();
            Country country = new Country();

            if (update)
            {
                while (!exit) // Enter Id to Update
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
            }

            while (!exit) // Product
            {
                // Input Assets 
                product.Show(context); //Show Products List

                Top("Please enter a Product Id from the list:");

                sInput = CheckStr("Product Id: ", sInput);
                if (!Empty(sInput))
                {
                    if (Exit(sInput))
                    {
                        exit = true;
                        validData = false;
                        break;
                    }

                    try
                    {
                        productId = Convert.ToInt32(sInput);
                        // Check Product exists  
                        if (product.CheckId(productId, context))
                        {
                            validData = true;
                            break;
                        }
                        else
                        {
                            validData = false;
                        }
                        break;
                    }
                    catch (Exception e)
                    {
                        validData = false;
                        MsgColor(e.Message);
                    }
                }
            }

            while (!exit) // Country
            {
                country.Show(context); //Show Countries List

                Top("Please enter a Country Id from the list:");
                sInput = CheckStr("Country Id: ", sInput);

                if (!Empty(sInput))
                {
                    if (Exit(sInput))
                    {
                        exit = true;
                        validData = false;
                        break;
                    }
                    try
                    {
                        countryId = Convert.ToInt32(sInput);
                        // Check Country exists  
                        if (country.CheckId(countryId, context))
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

            while (!exit) // Purchase Date
            {
                sInput = CheckStr("Purchase Date (DD/MM/YYYY): ", sInput);
                if (Exit(sInput))
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
                    newAsset.Add(dt, productId, countryId, context);
                }
                else
                {
                    // Update
                    newAsset.Update(id, dt, productId, countryId, context); // Works
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
                if (!Empty(input))
                {
                    if (Exit(input))
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
            }
        } // Delete 

    }
}
