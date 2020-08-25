using System;

namespace math_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 6;
            int secondNumber = 17;
            int total;

            total = firstNumber + secondNumber;
            Console.WriteLine(" sum of {0} and {1} is {2}", firstNumber, secondNumber, total);
            Console.ReadKey();

            Console.WriteLine(" String concatenation with names:");
            //string concatenation
            char firstInitial = 'K';
            string firstName = "Katie";
            string lastName = "McCann";

            string fullName = firstName + " " + lastName;
            Console.WriteLine(" Initial:{0} fullName: {1}",firstInitial, fullName);
            Console.ReadKey();
            // data type skill chaeck

            Console.WriteLine("Job Seeker Stats:");
            string Name = "Molly";
            string Address = " 24 Evergreen lane";
            char Gender = 'F';
            byte YearsOfExperiance = 3;
            string jobSeeker = Name + " " + Address + Gender + YearsOfExperiance;
            Console.WriteLine(" Name: {0}, Address: {1}, Gender: {2}, YearsOfExperiance {3},", Name, Address, Gender, YearsOfExperiance);
            Console.ReadKey();

            double Num1 = 33.33;
            double Num2 = 33.33;
            double Num3 = 33.34;

            double total2;

            total2 = Num1 + Num2 + Num3;
            Console.WriteLine(" sum of {0} and {1} and {2} is {3}", Num1,Num2,Num3,total2); 
            Console.ReadKey();

            int a = 13;
            int b = 5;
            Console.WriteLine("{0} + {1} = {2}", a,b, a + b);
            Console.WriteLine("{0} - {1} = {2}", a,b, a-b);
            Console.WriteLine("{0} * {1} = {2}", a,b, a*b);
            Console.WriteLine("{0} / {1} = {2}", a,b, a/b);
            Console.WriteLine("{0} % {1} = {2}", a,b, a % b);
            Console.ReadKey();
            /*
            int j= 10;
            int i = -j;
            Console.ReadKey();
            */

            //calc came out a bit off double check this section try again, re run
            int c = 100;
            int d = 20;
            Console.WriteLine("Intial values c = {0} d={1}", c,d);
            c += d;
            Console.WriteLine("After c +=b; c={0} d={1}", a,b);

            Console.WriteLine("please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("your name is: {0}",name);
            Console.ReadKey();
        }
    }
}
