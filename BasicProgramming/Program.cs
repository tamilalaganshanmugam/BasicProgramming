using System;

namespace BasicProgramming
{
    class Program
    {
        //1
        //Data - Properties/Variables

        //Defination
        //<AccessModifier> DataType VariableName
        internal int number;
        //int = 4 byte - Allocating memory

        //Declaration
        //<AccessModifier> DataType VariableName = Value
        private int numbers = 10;
        //int = 4 byte - Allocating memory + Assigning value

        //2
        //Behaviour - Methods/Functions
        //<AccessModifier> ReturnType MethodName (Parameters){}
        //ReturnType - void:No ReturnType
        //Stucture & Objects
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static void Main(string[] args)
        {
            PrintNoOfPrimeNumber(1000);
        }
        public static void PrintNoOfPrimeNumber(int n)//25
        {
            DateTime startTime = DateTime.Now;
            for(int i=1;i<=n;i++)
            {
                bool flag = true;

                for(int j=i-1;j>=2;j--)
                {
                    if(i%j==0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    Console.WriteLine(i);
            }
            DateTime endTime = DateTime.Now;
            Console.WriteLine(endTime - startTime);
        }
        private void Basics()
        {

            int a = 100;
            int b = 200;
            int c = 300;
            if (a == b && b == c && a == c)
            {

            }
            else
            {

            }
            int value = 10;
            switch (value)
            {
                case 10:
                    Console.WriteLine(10);
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
            while (true)
            {
                //Infinity loop
            }

            do
            {
                //Execute atleast once,Even the condition is false.
            }
            while (true);

            //Declaration;Codition;Incrementation/Decrementation
            for (int element = 0; ;element++)
            {
                //Infinity loop
            }
        }
        
    }
}
