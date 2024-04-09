/* Project: Asset Tracking
 * Main Program 
 * C# using Entity Framework
 * author : Pedro Martinez
 * Date: 04/04/2024
 */

using Asset;

// Added 
using static Asset.Utils;
using static Asset.CRUDAsset;
using System.Linq;
using System.ComponentModel.Design; // Asset Methods

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
    Product product = new Product();
    Country country = new Country();
    string[] entry = { "1", "2", "3", "C", "Q"};

    while (!exit)
    {
        Console.WriteLine("");
        WriteColor("Main Menu", "y");
        WriteColor("-----------------------------------------------", "y");
        WriteColor("(1) Assets", "g");
        WriteColor("(2) Show Products", "g");
        WriteColor("(3) Show Countries", "g");
        WriteColor("(C) Clear Screen", "g");
        WriteColor("(Q) Quit", "g");

        Console.WriteLine("");
        Console.Write("");

        input = CheckStr("Choose an Option: ", input);
        if (entry.Contains(input))
        {
            switch (input) // MainMenu 
            {
                case "1":
                    MenuAssets(context);
                    break;
                case "2":
                    product.Show(context);
                    break;
                case "3":
                    country.Show(context);
                    break;
                case "C":
                    Console.Clear();
                    break;
                case "Q":
                    exit = true;
                    break;
            }
        }
        else if (!Empty(input))
        {
            MsgColor("Invalid Entry! Please try again.");
        }
    }
    return exit;
}


static bool MenuAssets(DBCAsset context)
{
    bool exit = false;
    string input = "";
    MyAsset asset = new MyAsset();
    string[] entry = { "1", "2", "3", "4", "5", "C", "Q"};

    while (!exit)
    {
        Console.WriteLine("");
        WriteColor("Assets Menu", "y");
        WriteColor("-----------------------------------------------", "y");
        WriteColor("(1) Show Assets ( sort by Office and Date)", "g");
        WriteColor("(2) Show Assets ( sort by Date)", "g");
        WriteColor("(3) Add", "g");
        WriteColor("(4) Edit", "g");
        WriteColor("(5) Remove", "g");
        WriteColor("(C) Clear Screen", "g");
        WriteColor("(Q) Back to Main Menu", "g");

        Console.WriteLine("");
        input = CheckStr("Choose an Option: ", input);

        if (entry.Contains(input))
        {
            switch (input)
            {
                case "1":
                    asset.Show(true, context);
                    break;
                case "2":
                    asset.Show(false, context);
                    break;
                case "3":
                    // Add New Asset
                    InputAsset(false, context);
                    break;
                case "4":
                    // Edit
                    InputAsset(true, context);
                    break;
                case "5":
                    //  Delete
                    DeleteAsset(context);
                    break;
                case "C":
                    Console.Clear();
                    break;
                case "Q":
                    exit = true;
                    break;
            }
        }
        else if (!Empty(input))
        {
            MsgColor("Invalid Entry! Please try again.");
        }
    }
    return exit;
}