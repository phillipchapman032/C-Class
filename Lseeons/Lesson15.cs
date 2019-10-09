using System;

/* this class goes over the Lesson 15 content
Enums, Indexers & More */
namespace C_Class.Lseeons
{
    public class Lesson15
    {
        public const float pi = 3.14f;
        public const string words = "Happy Coding";


        public enum IceCreamFlavors : byte
        {
            Vanilla = 10, Chocolate,
            Strawberry, RockyRoad
        };

        protected int [] coneSizes = new int [] {5 , 10 ,15, 20};

        public int ConeArrayLength { get { return coneSizes.Length; } }

        public int this [int index]
        {
            get { return coneSizes [index];}
            set { coneSizes [index] = value;}
        }
        
        public void CheckExternalEnum()
        {
            int value = (int)Lesson15Enum.Wed;
            Console.WriteLine(Lesson15Enum.Wed + " " + value);
        
        }

        public void MyFavoriteFlavor(IceCreamFlavors flavor)

        {
            string message = "My favorie flavor is";
            switch (flavor)
            {
                case IceCreamFlavors.Vanilla:
                    message += IceCreamFlavors.Vanilla;
                    break;
                case IceCreamFlavors.Chocolate:
                    message += IceCreamFlavors.Chocolate;
                    break;
                case IceCreamFlavors.Strawberry:
                    message += IceCreamFlavors.Strawberry;
                    break;
                default:
                    message += IceCreamFlavors.RockyRoad;
                    break;


            }
            Console.WriteLine(message);

        }
    }
}