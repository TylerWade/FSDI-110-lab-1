using System;

namespace _110_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program(); //run myself
        }
        // constructor
        // TS : constructor(){}

        /**
        cons:
        - its a method
        - have the same name as the class
        - not return type (not even void)
         */
        public Program()
        {
            Console.WriteLine("Hello, I'm the constructor");
            SayHello(); //execute a function
            printHellos(5);
            string res = myFavColor(true);
            Console.WriteLine(res);

            var sumValue = Sum(21, 21);
            System.Console.WriteLine("Sum " + sumValue);

            var divValue = Div(42, 2);
            System.Console.WriteLine("Div Result " + divValue);

            TestArrays();
        }



        void TestArrays()
        {
            int[] numbers = new int[9];
            numbers[0] = 1; // you store values on the indexes
            numbers[1] = 42;
            numbers[2] = 34;

            // read stored values
            int theVal = numbers[2];

            for (int i = 0; i < numbers.Length; i++)
            {
                int theNumber = numbers[i];
                System.Console.WriteLine("from array " + theNumber);
            }
        }

         void homeWork()
        {
            int[] grades = new int[] { 2, 4, 2, 5, 1, 67, 45, 234, 56, 67, 3, 2134, 76, 98, 45, 123, 345, 5678 };

            // REAL HW use above to check
            //int[] grades = generateRandomArray();

            /* 
                Home Work (lab 1):
                - find the lowest value
                - find the greates value


                + how many are eve (divided by 2)
             */
        }

        int[] generateRandomArray()
        {
            int[] list = new int[950];
            for (int i = 0; i < 950; i++)
            {
                list[i] = new Random().Next(1000);
            }

            return list;
        }


        /*
            Ex 1:
            - create a myfavColor method
            - returns a string
            - that recieves a boolean thing
            - if the thing is false, return red
            - else return blue

            Ex2:
            - create a Sum Method
            - that revieves two int
            - returns the sum of them

            Ex3:
            - create a div method
            - that recieves two int
            - retunr the result of the division
         */

        /*
        method:
        -**
        - return type (what is the method going to return)
        - name
        - parameters
         */
        int SayHello()
        {
            Console.WriteLine("Hello I'm a method");
            int a = 98;
            if (a == 91)
            {
            }
            else
            {
                Console.WriteLine("its not 91");
            }
            return 2;
        }

        void TypeTests()
        {
            // var, let
            string name = "Tyler";
            int age = 20;
            double phi = 3.1415927;
            bool isItTrue = false;

            char letter = 'c';
            float weight = 255;
            decimal price = 123.456m;

        }

        void printHellos(int howMany)
        {
            // for loop
            for (int i = 0; i < howMany; i++)
            {
                System.Console.WriteLine("hello");
            }
        }

        string myFavColor(bool thing)
        {
            if (thing == false)
            {
                return "red";
            }
            else
            {
                return "blue";
            }
        }

        void test()
        {
            // generate random int
            int r = new Random().Next(50);
        }

        int Sum(int a, int b)
        {
            return a + b;
        }

        decimal Div(decimal num1, decimal num2)
        {
            System.Console.WriteLine(num1 / num2);
            return num1 / num2;

            // if num2 is a 0, then return 0
            if (num2 == 0)
            {
                System.Console.WriteLine("tried to divide by 0");
                return 0;
            }

            return num1 / num2;
        }
    }

}
