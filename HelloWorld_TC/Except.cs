using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace HelloWorld_TC
{
    class Except
    {
        static public void ProvokeException()
        {
            try
            {
                FileStream fs = new FileStream(@"X:\blubb.bla", FileMode.Open, FileAccess.Read);
                long len = fs.Length;
            }
            catch (DirectoryNotFoundException ex)
            {
                StreamWriter write = new StreamWriter("log.txt", true);
                write.WriteLine(ex.Message);
                write.Flush();
                write.Close();
            }
        }

        public static double Divide(int dividend, int divisor)
        {
            double solved = 0;
            if (divisor != 0)
                solved = dividend / divisor;
            else
                throw new DivideByZeroException("This is a custom exception");

            return solved;
        }
    }
}
