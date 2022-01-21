using System;

namespace ExamFirstSemester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------BIKE RENTAL SYSTEM------------------------");
            Bike b1 = new Bike("Royal Enfield Classic 350", 2021, "blue" , 321);
            Bike b2 = new Bike("Yamaha YZF R15 V3", 2019, "black" , 999);
            Bike b3 = new Bike("Hero Splendor Plus", 2022, "green" , 444);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
        }
    }
}