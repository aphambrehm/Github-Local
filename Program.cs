//Alexander Pham-Brehm
using System;
using System.Globalization;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code is used by the first exercise
            // It is left here, uncommented, so that it's easy for you to run
            // Once you complete it, feel free to comment these lines out
            // That way, you won't have every single exercise being run, each and
            // every time :)

            Basic_Console_IO bcio = new Basic_Console_IO();
            bcio.RunExercise(); // you will need to uncomment this line!

            // The two lines of code below are used by the next exercise.
            // When you decide to do that exercise, you'll need to uncomment
            // these two lines.
            //Basic_Arithmetic_Operators bao = new Basic_Arithmetic_Operators();
            //bao.RunExercise();

            // Similarly, you'll need to uncomment these lines...
            //Comparison_Operators co = new Comparison_Operators();
            //co.RunExercise();

            //Define_An_Instance_Method daim = new Define_An_Instance_Method();
            //daim.RunExercise();

            //HelloPrinter hp = new HelloPrinter();
            //hp.printHello();

            //NumberPrinter np = new NumberPrinter();
            //np.printTwoNumbers();

            //Data_Type_Explanations dte = new Data_Type_Explanations();
            //dte.RunExercise();
            //dte.ToUpper();
            //dte.ToLower();
        }
    }

    class Basic_Console_IO
    {
        public void RunExercise()
        {
            Console.WriteLine("Hello Git and Github");
        }
    }

    class Basic_Arithmetic_Operators
    {
        public void RunExercise()
        {
            {
                int x = 2, y = 8, z;

                Console.WriteLine("2 times 8 equals " + x * y);	// multiply
                Console.WriteLine("8 divided by 2 equals " + y / x);	// divide
                Console.WriteLine("8 mod 2 equals " + y % x);		// modulus
                Console.WriteLine("2 plus 8 equals " + (x + y));	// add
                Console.WriteLine("8 minus 2 equals " + (y - x));	// subtract

                z = ((y - (2 * x)) * 6) / 12;
                Console.WriteLine("z now equals " + z);
            }
        }
    }

    class Comparison_Operators
    {
        public void RunExercise()
        {
            Console.WriteLine("Get 2 integers & store them, then compare them using <, <=, etc, etc");
        }
    }

    class Define_An_Instance_Method
    {
        public void RunExercise()
        {
            Console.WriteLine("Hello, World, from the Instance Method Exercise!");
        }
    }

    class HelloPrinter
    {
        public void printHello()
        {
            Console.WriteLine("Hello User!!! Nice to meet you!");
        }
    }

    class NumberPrinter
    {
        public void printTwoNumbers()
        {
            string NPInput;
            int x;
            double y;
            Console.WriteLine("Put in one integer number");
            NPInput = Console.ReadLine();
            Int32.TryParse(NPInput, out x);
            Console.WriteLine("You put in: "+ x);

            Console.WriteLine("Put in another integer number");
            NPInput = Console.ReadLine();
            Double.TryParse(NPInput, out y);
            Console.WriteLine("You also put in: " + y);

            Console.WriteLine("The two integer number you put in are: "+x +","+ y);
        }
    }

    class Data_Type_Explanations
    {
        public void RunExercise()
        {
            int x=7;
            double y = 14;
        Console.WriteLine(x+","+y);
        }

        public void ToUpper()
        {
            string str1 = "hello";
            string str2, str3;

            str2 = str1.ToUpper(new CultureInfo("en-US", false));
            str3 = str1.ToUpper(new CultureInfo("tr-TR", false));

            ShowCodePoints("str1", str1);
            ShowCodePoints("str2", str2);
            ShowCodePoints("str3", str3);
            Console.WriteLine("str2 is {0} to str3.",
            String.CompareOrdinal(str2, str3) == 0 ? "equal" : "not equal");
        }

        public static void ShowCodePoints(string varName, string s)
        {
            Console.Write("{0} = {1}: ", varName, s);
            foreach (ushort u in s)
                Console.Write("{0:x4} ", u);
            Console.WriteLine();
        }

        public void ToLower()
        {
            string [] info = {"Name", "Title", "Age", "Location", "Gender"};

        Console.WriteLine("The initial values in the array are:");
        foreach (string s in info)
            Console.WriteLine(s);

        Console.WriteLine("{0}The lowercase of these values is:", Environment.NewLine);        

        foreach (string s in info)
            Console.WriteLine(s.ToLower());

        Console.WriteLine("{0}The uppercase of these values is:", Environment.NewLine);        

        foreach (string s in info)
            Console.WriteLine(s.ToUpper());
        }

        public static void CodePoints(String title, String s)
        {
            Console.Write("{0}The code points in {1} are: {0}", Environment.NewLine, title);
            foreach (ushort u in s)
                Console.Write("{0:x4} ", u);
            Console.WriteLine();
        }
        // I don't quite get this part, can I get an example? 
    }
    // Put the Data_Type_Explanations stuff here
    // Don't forget the following (detailed in the Word .DOC that describes this exercise):

    //answers here on what values can be stored in the given data types:

    //answer for what the u prefix means:

    //answer for what the difference between float/double/decimal are:
    // What is a typical usage of decimal instead of float/double?

    //answers for the 5 questions:
}
