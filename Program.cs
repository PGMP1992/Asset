/* Project: Asset Tracking
 * Main Program 
 * C# using Entity Framework
 * author : Pedro Martinez
 * Date: 04/04/2024
 */

using Asset;

// Added 
using static Asset.Utils;
using static Asset.CRUDAsset; // Asset Methods

internal class Program
{
    private static void Main(string[] args)
    {
        // Vars
        bool exit = false;

        // Create DbContext
        DBCAsset context = new DBCAsset();

        while (!exit)
        {
            Console.WriteLine();
            WriteColor("Track Asset App ", "y");

            exit = MainMenu(context);
        }

        static bool MainMenu(DBCAsset context)
        {
            bool exit = false;
            string input = "";

            while (!exit)
            {
                WriteColor("Main Menu", "y");
                WriteColor("-----------------------------------------------", "y");
                WriteColor("(1) Assets", "g");
                WriteColor("(2) Products", "g");
                WriteColor("(3) Countries", "g");
                WriteColor("(Q) Quit", "g");

                Console.WriteLine("");
                Console.Write("");

                input = CheckStr("Choose an Option: ", input);

                switch (input) // MainMenu 
                {
                    case "1":
                        MenuAssets(context);
                        exit = false;
                        break;
                    case "2":
                        MenuProducts(context);
                        exit = false;
                        break;
                    case "3":
                        MenuCountries(context);
                        exit = false;
                        break;
                    case "Q":
                        exit = true;
                        break;
                }
            }
            return exit;
        }



        static bool MenuAssets(DBCAsset context)
        {
            bool exit = false;
            string input = "";
            MyAsset asset = new MyAsset();

            while (!exit)
            {
                WriteColor("Assets Menu", "y");
                WriteColor("-----------------------------------------------", "y" );
                WriteColor("(1) Show Assets ( sort by Office and Date)", "g");
                WriteColor("(2) Show Assets ( sort by Date)", "g");
                WriteColor("(3) Add", "g");  
                WriteColor("(4) Edit", "g");
                WriteColor("(5) Remove", "g");
                WriteColor("(Q) Back to Main Menu", "g");

                Console.WriteLine("");
                Console.Write("");

                input = CheckStr("Choose an Option: ", input);

                switch (input)
                {
                    case "1":
                        asset.Show(true, context);
                        exit = false;
                        break;
                    case "2":
                        asset.Show(false, context);
                        exit = false;
                        break;
                    case "3":
                        // Add New Asset
                        InputAsset(false, context);
                        exit = false;
                        break;
                    case "4":
                        // Edit
                        InputAsset(true, context);
                        exit = false;
                        break;
                    case "5":
                        //  Delete
                        DeleteAsset(context);
                        exit = false;
                        break;
                    case "Q":
                        exit = true;
                        break;
                }
            }
            return exit;
        }

        static bool MenuProducts(DBCAsset context)
        {
            bool exit = false;
            string input = "";

            while (!exit)
            {
                WriteColor("Products Menu", "y");
                WriteColor("-----------------------------------------------", "y");
                WriteColor("(1) Show Products", "g");
                WriteColor("(2) Add", "g");
                WriteColor("(3) Edit", "g");
                WriteColor("(4) Remove", "g");
                WriteColor("(Q) Back to Main Menu", "g");

                Console.WriteLine("");
                Console.Write("");

                input = CheckStr("Choose an Option: ", input);

                switch (input)
                {
                    case "1":
                        //prod.Show(context);
                        exit = false;
                        break;
                    case "2":
                        //prod.Show(context);
                        exit = false;
                        break;
                    case "3":
                        // Add New Asset
                        //InputProd(false, context);
                        exit = false;
                        break;
                    case "4":
                        // Edit
                        //InputProd(true, context);
                        exit = false;
                        break;
                    case "5":
                        //  Delete
                        //DeleteProd(context);
                        exit = false;
                        break;
                    case "Q":
                        exit = true;
                        break;
                }
            }
            return exit;
        }

        static bool MenuCountries(DBCAsset context)
        {
            bool exit = false;
            string input = "";

            while (!exit)
            {
                WriteColor("Countries Main Menu", "y");
                WriteColor("-----------------------------------------------", "y");
                WriteColor("(1) Show countries", "g");
                WriteColor("(2) Add", "g");
                WriteColor("(3) Edit", "g");
                WriteColor("(4) Remove", "g");
                WriteColor("(Q) Back to Main Menu", "g");

                Console.WriteLine("");
                Console.Write("");

                input = CheckStr("Choose an Option: ", input);

                switch (input)
                {
                    case "1":
                        //country.Show(context);
                        exit = false;
                        break;
                    case "2":
                        //country.Show(context);
                        exit = false;
                        break;
                    case "3":
                        // Add New Asset
                        //InputCountry(false, context);
                        exit = false;
                        break;
                    case "4":
                        // Edit
                        //InputCountry(true, context);
                        exit = false;
                        break;
                    case "5":
                        //  Delete
                        //DeleteCountry(context);
                        exit = false;
                        break;
                    case "Q":
                        exit = true;
                        break;
                }
            }
            return exit;
        }
    }
}