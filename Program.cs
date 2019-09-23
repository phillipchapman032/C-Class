using System;
using C_Class.Lseeons;

namespace C_Class
{
    /*This class is the start of my application.
    Lesson 3 - My First Application */
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            MyLesson5Example();
        } // End Method Main

        static void MyLesson5Example()
        {
            Lesson5 myFive = new Lesson5();
            myFive.ConvertFloatToInt();
            myFive.LongFromInt();
        } // end method my lesson 5 examples

     } // End Class
} // end namespace
