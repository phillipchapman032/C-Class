using System;

/* This class is a child class of House
Lesson 12 Inheritance */

namespace C_Class
{
    public class Condo : House
    {
        public string Balcony{ get; set;}
        public Condo()
            :this("second floor")  {   }
        public Condo(string balcony)
            : base(32, "concrete")
        {
            Balcony = balcony;
        }

        public void Maintenance() {  base.DoorOpenClose();       }

        public override void DoorOpenClose() 
        {
            base.DoorOpenClose();
            Console.WriteLine("This condo door is closed");
        } 

    }
}