class MIKIS
{
    static void Main()
    {
        // You can tweak this, idk why i added it:
        bool debug = false;

        // Reads file from path
        string[] lines = System.IO.File.ReadAllLines(@"C:\MIKIS\main.mikis");

        // Variables
        string inptc1;
        Dictionary<string, string> strvars = new();
        Dictionary<string, int> intvars = new();
        Dictionary<string, bool> boolvars = new();

        // Checks if debug is on, if yes it does stuff
        if (debug == true)
        {
            // Write all lines
            System.Console.WriteLine("Contents of " + @"C:\MIKIS\main.mikis");
            Console.WriteLine("\n");
            foreach (string line in lines)
            {
                Console.WriteLine("  " + line);
            }

            // Show line count
            Console.WriteLine("\n" + lines.Length);
        }
        
        // Does this for every line
        for(int i = 0; i < lines.Length; i++)
        {
            // Checks for variables in line
            if (lines[i].StartsWith("var !"))
            {
                string st1 = lines[i].Split('!', '!')[1];
                string st2 = lines[i].Split('"', '"')[1];
                string st3 = lines[i].Split('.', '.')[1];

                if (st3 == "string")
                {
                    strvars[st1] = st2;
                }
                if (st3 == "int")
                {
                    intvars[st1] = Int32.Parse(st2);
                }
                if (st3 == "bool")
                {
                    if (st2 == "true")
                    {
                        boolvars[st1] = true;
                    }
                    if (st2 == "false")
                    {
                        boolvars[st1] = false;
                    }
                }
            }
            
            // Class Console
            if (lines[i].Contains("Console."))
            {
                if (lines[i].Contains("Console.Print("))
                {
                    if (lines[i].EndsWith(".VarMode(string);"))
                    {
                        string st1 = lines[i].Split('"', '"')[1];
                        string var_value = strvars[st1];
                        Console.WriteLine(var_value);
                    }
                    else if (lines[i].EndsWith(".VarMode(int);"))
                    {
                        string st1 = lines[i].Split('"', '"')[1];
                        int var_value = intvars[st1];
                        Console.WriteLine(var_value);
                    }
                    else if (lines[i].EndsWith(".VarMode(bool);"))
                    {
                        string st1 = lines[i].Split('"', '"')[1];
                        bool var_value = boolvars[st1];
                        Console.WriteLine(var_value);
                    }

                    else
                    {
                        if (lines[i].Contains("Console.Print(INPUT);"))
                        {
                            inptc1 = Console.ReadLine();
                            Console.WriteLine(inptc1);
                        }
                        else
                        {
                            string st1 = lines[i].Split('"', '"')[1];
                            Console.WriteLine(st1);
                        }
                    }
                }

                if (lines[i].Contains("Console.GetInput("))
                {
                    inptc1 = Console.ReadLine();
                }

                if (lines[i].Contains("Console.GetKey("))
                {
                    Console.ReadKey();
                    Console.WriteLine("");
                }
            }
        }
        // Do on end
        Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
    }
}

// Mikicrep#5589 <- Discord
/* 
Version:
Dev 4

Curent Commit info:
1. Added better string, int and bool variables
*/