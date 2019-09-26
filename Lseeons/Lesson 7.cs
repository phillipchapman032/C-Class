using System;

namespace C_Class.Lseeons
{
    public class Lesson7
    {
        public void BasicMath()
        {
            int a = 20, b = 10;

            int total1 = a + b;
            int total2 = a - b;
            int total3 = a * b;
            int total4 = b / a;

            Console.WriteLine("Addition = {0}, Subtraction {1}", total1, total2);
            Console.WriteLine("Multiplication = {0}, Division = {1}", total3, total4);

        }//end method basic math

        public void BasicModulus()
        {
            int total = 10 % 20;
            Console.WriteLine(total);
        } // end method basic modulus

        public void MyCheckOperator1()
        {
            int val = 100, val2 = 100;
            Console.WriteLine(checked(val * val2));
        }// end method my check operator 1

        public void MyCheckOperator2()
        {
            int able = 250, beta = 45;
            checked
            {
                int myCheck = able * beta;
                Console.WriteLine(myCheck);

            }

        } // end method my check operator 2

        /* The shift left operator will take the value as a primitive type and convert it to the binary
        version binary is grouped in 4's, so it will shift the binary version of the number to the left 
        by the number of spaces. the high-order bits outside the range of the result type of x 
        are discarded, the remaining bits are shifted left, and the low-order empty bit positions
        are set to zero.
         */
        public void MyLeftShiftOperator()

        {
            // The number 15 converted to binary = 1111
            int value = 15;

            // Shifting value by two results in 0011 1100 which is the number 60.
            value <<= 2;
            Console.WriteLine(value);


        }   // end my left shift operator

        /*
        The shift right operator will take the value as a primitive type 
        and convert it to binary version. Binary is grouped in 4's, so it 
        will shift the binary version of the number to the right by the number
        of spaces

        When x is of type int or long, the low-order bits are discarded, 
        the remaining bits are shifted right, and the high-order empty bit
        positions are set to zero if x is non-negative and set to one if x
        is negative.

        When x is of type uint or ulong, the low-order bits of x are discarded,
        the remaining bits are shifted right, and the high-order empty bit
        positions are set to zero*/

        public void MyRightShiftOperator()
        {
            // The number 30 converted to binary = 0001 1110
            int value = 30;

            // Shifting the value by two results in 0111
            value >>= 2;
            Console.WriteLine(value);
        }

        /* 
       This AND bitwise compares the binary of both numbers. Only the 
       matched sets carry over to the answer
        */

        public void MyAndAssignmentOperator()
        {
            // The number 10 converted to binary is 1010
            int value = 10;
            // The number 2 in binary is 0010
            value &= 2; // answer is 2.
            Console.WriteLine(value);
        } // end method my and assignment operator

        /*This or bitwise compares the binary of both numbers. only 1 of
        the set's 1's carry over to the answer */

        public void MyOrAssignmentOperator()
        {
            int value = 15; // 1111
            int value2 = 30; // 0001 1110

            value |= value2; // answer is 0001 1111 or 31
            Console.WriteLine(value);
        } // end method my or assignment operator
          /*
          This XOR bitwise compares binary of both numbers. If the bits are different,
          a 1 takes its place
           */
        public void MyXOrAssignmentOperator()
        {
            int value = 15; //1111
            int value2 = 30; // 0001 1110

            value ^= value2; // answer is 0001 0001 or 17
            Console.WriteLine(value);
        } // end method MyIncrementDecrementExample()

        public void MyIncrementDecrementExample()
        {
            int alpha = 11, beta = 16;
            alpha++; // alpha = alpha + 1
            Console.WriteLine(alpha);
            ++alpha; // alpha = 1 + alpha
            Console.WriteLine(alpha);

            beta--;
            Console.WriteLine(beta);
            --beta; // beta = 1 - beta;
            Console.WriteLine(beta);
            
        } // end method my increment decrement example



    } //end class
}//end namespace
