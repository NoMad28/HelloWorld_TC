using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld_TC
{
    class Program
    {
        //Visit tacticalcode.blogspot.com !

        static bool EError = false;
        static void Main(string[] args)
        {
            //helloworldextended(args);
            //Except.ProvokeException();
            double s = 0;
            try
            {
                s = Except.Divide(5,0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }

        static void helloworldextended(string[] args)
        {
            string name = String.Empty;
            User usr = new User();
            usr.IncorrectEntry += new User.IncorrectEntryEventHandler(usr_IncorrectEntry);

            if (args.Length == 0)
            {
                Console.WriteLine("Please enter your name:");
                name = Console.ReadLine();
            }
            else if (args.Length == 1)
            {
                name = args[0];
            }
            else
                Console.WriteLine("Usage: HelloWorldTC [name]");

            if (!String.IsNullOrEmpty(name))
            {
                usr.Name = name;
                usr.Well = usr.GetWellBeing();
                Console.Write("\n");

                if (!EError && usr.Well)
                    Console.WriteLine("Oh, great!");
                else if (!EError && !usr.Well)
                    Console.WriteLine("I'm sorry for you :'(");
                else
                    Console.WriteLine("Incorrect entry!");
            }
            else
                Console.WriteLine("Please specify a name!");

        }

        static void usr_IncorrectEntry()
        {
            EError = true;
        }


        delegate void TestHandler();
        static void DelegateTest()
        {
            TestHandler th = new TestHandler(DoSomething);
            th += new TestHandler(DoSomething);
            th += new TestHandler(DoSomething);
            th();
        }
        static void DoSomething()
        {
            Console.WriteLine("Something");
        }
    }
}
