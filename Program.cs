using System;
using C_Class.Lseeons;
using C_Class;
using CSharpClass.Lessons;
using C_Class.Lessons;

namespace CSharpClass
{
    /*This class is the start of my application.
    Lesson 3 - My First Application */
    class program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //MyLesson5Examples();
            //MyLesson6Examples();
            //MyLesson7Examples();
            // MyLesson8Examples();
            //MyOtherLesson8Examples();
            // MyLesson9Examples();
            //MyLesson10Examples();
            //MyLesson11Examples();
            //MyBeerSong();
            //MyLesson12Examples();
            // MyLesson13House();
            //MyLesson14Examples();
           // MyLesson15Examples();
        } // End Method Main

            static void MyLesson15Examples()
            {
                Lesson15 my15 = new Lesson15();
                my15.CheckExternalEnum();
                my15.MyFavoriteFlavor(Lesson15.IceCreamFlavors.Chocolate);

                my15[2] = 17;
                for (int i = 0 ; i < my15.ConeArrayLength; i++)
                {
                    Console.WriteLine("Value of {0} = {1}", i, my15[i]);
                } 
            }


        static void MyLesson14Examples()
        {
                Lesson14Static.CelsiusToFahrenheit("34.5");
                Lesson14Static.FahrenheitToCelsius("64");

                Lesson14Derived myLesson14 = new Lesson14Derived(8);
                myLesson14.ShowResultFeet();
                myLesson14.ShowResultMiles();
        }

        static void MyLesson12Examples()
        {
            Condo myCondo = new Condo();
            myCondo.DoorOpenClose();


            House myHouse = new Condo();
            myHouse.DoorOpenClose();

        }

        static void MyBeerSong()
        {
            BottlesOfBeer beer = new BottlesOfBeer();
            Console.WriteLine(beer.LetsSing());
        }

        static void MyLesson11Examples()
        {
            Lesson11 myEleven = new Lesson11("Happy", 42);
            Lesson11 myOtherEleven = new Lesson11(22);
            Lesson11 myLesson11 = new Lesson11();

            Lesson11Struct myStruct = new Lesson11Struct(9.99m, "King", "The Stand");
            int myValue = 14;
            myEleven.MyBasicRefExample(ref myValue);
            Console.WriteLine(myValue + " from program");

            string first, last;
            myLesson11.MyBasicOutExample("Foghorn Leghorn", out first, out last);
            Console.WriteLine(first);
            Console.WriteLine(last);

        } // end method my lesson 11 examples

        static void MyLesson10Examples()
        {
            Lesson10 myTen = new Lesson10();
            myTen.BasicPublicMethod();
            Lesson5 myFive = new Lesson5();
            myFive._myLongValue = 12345L; // can see because its internal

        } // end method my lesson 10 examples

        static void MyLesson9Examples()
        {
            Lesson9 myNine = new Lesson9();
            myNine.BasicArray();
            myNine.MultiArraySample();
            myNine.My3DArrayExample();
            myNine.MyJaggedArrayExample();

        } // end method my lesson 9 examples

        static void MyLesson8Examples()
        {
            Lesson8 myEight = new Lesson8();
            myEight.BasicIfStatement();
            myEight.BasicIfElseExample();
            myEight.BasicIfElseChainExample();
            myEight.BasicAndConditionExample();
            Console.WriteLine(myEight.BasicOrConditionExample(11));
            myEight.BasicTernaryOperatorExample(21);
            myEight.BasicSwitchExample(3);
            myEight.BasicWhileLoop();
            myEight.BasicDoWhileLoopExample();
            myEight.BasicForLoopExample(10);
            myEight.BasicJumpStatementExample("Tuesday");
        }

        static void MyLesson7Examples()
        {
            Lesson7 mySeven = new Lesson7();
            mySeven.BasicMath();
            mySeven.BasicModulus();
            mySeven.MyCheckOperator1();
            mySeven.MyCheckOperator2();
            mySeven.MyLeftShiftOperator();
            mySeven.MyRightShiftOperator();
            mySeven.MyAndAssignmentOperator();
            mySeven.MyOrAssignmentOperator();
            mySeven.MyXOrAssignmentOperator();
            mySeven.MyIncrementDecrementExample();



        } // end method My Lesson 7 examples


        static void MyLesson6Examples()
        {
            Lesson6 mySix = new Lesson6();
            mySix.MyTrimExample();
            mySix.MyEqualsExample();
            mySix.MyLowerUpperExample();
            mySix.MyStringLength();
            string myJoined = mySix.MyJoinedStrings("Happy", "Coding");
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
