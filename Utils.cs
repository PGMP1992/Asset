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
            WriteColor(line, "y");
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
            return s == "Q";
        }

        //  Default error message 
        public static void MsgInvalidEntry()
        {
            MsgColor("Invalid Entry! Please try again: ");
        }

        //  Default error message 
        public static void MsgColor(string s)
        {
            WriteColor(s, "y");
            Console.WriteLine("");
        }

        public static void ErrorMsg(string s)
        {
            WriteColor(s, "r");
            Console.WriteLine("");
        }

        public static void Top(string prompt)
        {
            WriteColor(prompt, "y");
        }

        // Color text in Msg 
        public static void WriteColor(string s, string color)
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
            Console.WriteLine(s);
            Console.ResetColor();
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

    } //class 

} //namespace


