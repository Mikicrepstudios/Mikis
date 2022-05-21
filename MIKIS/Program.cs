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
        string cstr1 = "",     cstr2 = "",     cstr3 = "",     cstr4 = "";
        int    cint1 = 0,      cint2 = 0,      cint3 = 0,      cint4 = 0;

        /* 
        TODO:

        bool   cbool1 = false, cbool2 = false, cbool3 = false, cbool4 = false;
        */

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

                if (st1 == "cstr1")
                {
                    string st2 = lines[i].Split('"', '"')[1];
                    cstr1 = st2;
                }
                else if (st1 == "cstr2")
                {
                    string st2 = lines[i].Split('"', '"')[1];
                    cstr2 = st2;
                }
                else if (st1 == "cstr3")
                {
                    string st2 = lines[i].Split('"', '"')[1];
                    cstr3 = st2;
                }
                else if (st1 == "cstr4")
                {
                    string st2 = lines[i].Split('"', '"')[1];
                    cstr4 = st2;
                }

                if (st1 == "cint1")
                {
                    string st2 = lines[i].Split('"', '"')[1];
                    cint1 = Int32.Parse(st2);

                }
                else if (st1 == "cint2")
                {
                    string st2 = lines[i].Split('"', '"')[1];
                    cint2 = Int32.Parse(st2);
                }
                else if (st1 == "cint3")
                {
                    string st2 = lines[i].Split('"', '"')[1];
                    cint3 = Int32.Parse(st2);
                }
                else if (st1 == "cint4")
                {
                    string st2 = lines[i].Split('"', '"')[1];
                    cint4 = Int32.Parse(st2);
                }
            }
            
            // Class Console
            if (lines[i].Contains("Console."))
            {
                if (lines[i].Contains("Console.Print("))
                {
                    if (lines[i].Contains("Console.Print(INPUT);"))
                    {
                        inptc1 = Console.ReadLine();
                        Console.WriteLine(inptc1);
                    }
                    else if (lines[i].Contains("Console.Print(cstr1)"))
                    {
                        Console.WriteLine(cstr1);
                    }
                    else if (lines[i].Contains("Console.Print(cstr2)"))
                    {
                        Console.WriteLine(cstr2);
                    }
                    else if (lines[i].Contains("Console.Print(cstr3)"))
                    {
                        Console.WriteLine(cstr3);
                    }
                    else if (lines[i].Contains("Console.Print(cstr4)"))
                    {
                        Console.WriteLine(cstr4);
                    }
                    else if (lines[i].Contains("Console.Print(cint1)"))
                    {
                        Console.WriteLine("" + cint1.ToString());
                    }
                    else if (lines[i].Contains("Console.Print(cint2)"))
                    {
                        Console.WriteLine("" + cint2.ToString());
                    }
                    else if (lines[i].Contains("Console.Print(cint3)"))
                    {
                        Console.WriteLine("" + cint3.ToString());
                    }
                    else if (lines[i].Contains("Console.Print(cint4)"))
                    {
                        Console.WriteLine("" + cint4.ToString());
                    }
                    else {
                        string st1 = lines[i].Split('"', '"')[1];
                        Console.WriteLine(st1);
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
// Curent Commit fixed int variable(s) (second try)