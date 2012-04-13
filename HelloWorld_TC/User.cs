using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld_TC
{
    public class User
    {
        public bool Well = false;
        public string Name = String.Empty;

        public event IncorrectEntryEventHandler IncorrectEntry;
        public delegate void IncorrectEntryEventHandler();

        public bool GetWellBeing()
        {
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld_TC
{
    public class User
    {
        public bool Well = false;
        public string Name = String.Empty;

        public event IncorrectEntryEventHandler IncorrectEntry;
        public delegate void IncorrectEntryEventHandler();

        public bool GetWellBeing()
        {
            Console.WriteLine("How are you, " + Name + "?"); //Windows FTW
            Console.WriteLine("[G]ood, [B]ad: ");
            Char c = Console.ReadKey().KeyChar;

            switch (c)
            {
                case (char)66:
                case (char)98:
                {
                    return false;
                }
                case (char)71:
                case (char)103:
                {
                    return true;
                }
                default:
                {
                    IncorrectEntry();
                    return false;
                }
            }
        }
    }
}
