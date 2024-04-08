using Microsoft.Identity.Client;

namespace Asset
{
    internal class Utils
    {
        // Draw a line the size of the string
        public static void DrawLine(string s)
        {
            string line = "";
            for (int i = 0; i <= s.Length; i++)
            {
                line += "-";
            }
            MsgColor(line, "y");
        }

        // Check if Empty String 
        public static bool Empty(string s)
        {
            s = s.Trim().ToUpper();
            if (s.Length == 0) { return true; }
            else { return false; }
        }

        // Check int == 0 
        public static bool Empty(int i)
        {
            if (i == 0) { return true; }
            else { return false; }
        }

        // Prompt and checks string after formatting 
        public static string CheckStr(string prompt, string s)
        {
            string str;
            Console.Write(prompt);
            str = Console.ReadLine().Trim().ToUpper();
            if (str.Length == 0)
            {
                MsgInvalidEntry();
            }
            return str;
        }

        // Check String returns Q to exit program 
        public static bool Exit(string s)
        {
            if (s == "Q")
            {
                MsgColor("Exiting Program. Thank you!", "y");
                return true;
            }
            else
            {
                return false;
            }
        }

        
        /*
        public static int CheckData(int i)
        {
            bool result = true;
            try
            {
                s.Trim().ToUpper().ToInt();
            }
            catch (Exception) 
            {
                result = false;
                MsgInvalidEntry();
            }

            return result;
        }

        public static bool CheckDate(string s)
        {
            bool result = true;
            try
            {
                s.Trim().ToUpper().ToDateTime();
            }
            catch (Exception)
            {
                result = false;
                MsgInvalidEntry();
            }
            return result;
        }
        */

        //  Default error message 
        public static void MsgInvalidEntry()
        {
            Console.Beep();
            MsgColor("Invalid Entry! Please try again: ", "r");
        }

        public static void Top(string prompt)
        {
            MsgColor(prompt, "y");
            MsgColor("----------------------------------------", "b");
            MsgColor("Enter \"Q\" " + "anytime to exit.", "b");
            MsgColor("----------------------------------------", "b");
        }

        // Color text in Prompt 
        public static void MsgColor(string msg, string color)
        {
            switch (color)
            {
                case "y":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "r":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "g":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "b":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "w":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            Console.WriteLine(msg);
            Console.ResetColor();
        }

    } //class 

} //namespace


