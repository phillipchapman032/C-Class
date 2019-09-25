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
            //MyLesson5Example();
            MyLesson6Examples();
            //MyLesson5Example();
        } // End Method Main
        static void MyLesson6Examples()
        {
            Lesson6 mySix = new Lesson6();
            mySix.MyTrimExample();
            mySix.MyEqualsExample();
            mySix.MyLowerUpperExample();
            mySix.MyStringLength();
            string myJoined = mySix.MyJoinedStrings("Happy","Coding");
            Console.WriteLine(myJoined);
            string myFav = mySix.MyStringBuilder("Buffalo Wings", 2);
            Console.WriteLine(myFav);
            mySix.MyExampleChar();
            mySix.MyEscapeExample();
            mySix.MyPlaceHolderExample("Pacaman", "retro");


            // end method my lesson 6 examples

        } // end method my lesson 6 examples

        static void MyLesson5Example()
        {
            Lesson5 myFive = new Lesson5();
            myFive.ConvertFloatToInt();
            myFive.LongFromInt();
        } // end method my lesson 5 examples

     } // End Class
} // end namespace
