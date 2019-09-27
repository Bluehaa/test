using System;

namespace helloword
{
    class Program
    {
        static void Main(string[] args)
        {
            string aFriend = "Bill";
            //Console.WriteLine("Hello World!");
            Console.WriteLine("hello " + aFriend);
            Console.WriteLine($"Hello {aFriend}");

            aFriend = "Maira";
            Console.WriteLine("hello " + aFriend);
            Console.WriteLine($"Hello {aFriend}");

            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

            //lession 4
            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            string sayhello = "Hello World!";
            Console.WriteLine(sayhello);
            sayhello = sayhello.Replace("Hello","Greetings");
            Console.WriteLine(sayhello);

            Console.WriteLine(sayhello.ToUpper());
            Console.WriteLine(sayhello.ToLower());

            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            Console.WriteLine(songLyrics.StartsWith("goodbye"));
            Console.WriteLine(songLyrics.EndsWith("hello"));


            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            double max1 = double.MaxValue;
            double min1 = double.MinValue;
            Console.WriteLine($"The range of double is {min1} to {max1}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            decimal min2 = decimal.MinValue;
            decimal max2 = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min2} to {max2}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);


            //cal the area of circle
            double length = 0.025;
            double area = Math.PI * (length * length);
            Console.WriteLine("the area of the circle is " + area);

            Console.ReadLine();
        }
    }
}
