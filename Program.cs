/*using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hey");
            Console.WriteLine("Hello");
            Console.WriteLine("What's your age?");
            String name;*/

/*using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 10;
            int y = 20;
            double height = 181.2;
            bool alive = true;
            String name = "Bro";
            const float pi = 3.141f;

            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            double e = 10;
            int f = Convert.ToInt32(e);
            Console.WriteLine(f);

            String s = "123";
            int z = Convert.ToInt32(s);
            Console.WriteLine(z);
            Console.WriteLine(z.GetType());

            Console.WriteLine($"Your name is {name}");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(height);
            Console.WriteLine("Your Age is " + x);
            Console.WriteLine($"Your height is {height}.");
            Console.WriteLine($"He is alive {alive}");
            Console.WriteLine(pi);
        }
    }
}
*/

/*using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {*/
/*Console.WriteLine("What is your Name?");
String name = Console.ReadLine();
Console.WriteLine("Hello " + name);
*/
/*Console.WriteLine("Enter your Age...");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your Age is { age }");
*/
/*double x = 3;
double y = 4;
double a = Math.Pow(x, 2);
Console.WriteLine(a);
double b = Math.Ceiling(3.78);
Console.WriteLine(b);
double c = Math.Floor(3.78);
Console.WriteLine(c);
double d = Math.Round(3.78);
Console.WriteLine(d);
*/

/*Random random = new Random();
Console.WriteLine(random.Next(1, 99));
Console.WriteLine(random.Next(1, 99) + 100);

Console.WriteLine(random.NextDouble());
*/


//Hypotenuse Calculator Program

/*Console.WriteLine("Enter the Side A");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the Side B");
double b = Convert.ToDouble(Console.ReadLine());

double c = Math.Sqrt((a * a) + (b * b));

Console.WriteLine("Side C is: " + c);
*/
/*
}
}
}
*/



/*using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age<=0)
            {
                Console.WriteLine("Not Born");
            }
            else if (age>0 && age<=18)
            {
                Console.WriteLine("You're a Teen");
            }
            else if(age>18 && age<70)
            {
                Console.WriteLine("You're a Senior Citizen");
            }
            else
            {
                Console.WriteLine("DIE!");
            }
        }
    }
}
*/

/*using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess!What day is it Today");
            String day = Console.ReadLine();

            switch(day)
            {
                case "Monday":
                    Console.WriteLine("It's Monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Tuesday");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Thursday");
                    break;
                case "Friday":
                    Console.WriteLine("It's friday");
                    break;
                case "Saturday":
                    Console.WriteLine("It's Saturday");
                    break;
                case "Sunday":
                    Console.WriteLine("It's Sunday");
                    break;
                default:
                    Console.WriteLine(day + " is not a Day!");
                    break;

            }
        }
    }
}
*/

//while loop
/*using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "";

            while(name == "")
            {
                Console.WriteLine("Enter your Name");
                name = Console.ReadLine();
            }
            Console.WriteLine("Hello " + name);

        }
    }
}
*/

//for loop
/*using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i<10; i=i+2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}*/


/*using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Rows:");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Number of Columns:");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your desired Symbol:");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
*/

/*using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int guesses;
            int number;
            String response;

            while(playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while(guess!=number)
                {
                    Console.WriteLine("Guess a number between " + min + "-" + max + ":");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess :  "+ guess);

                    if (guess>number)
                    {
                        Console.WriteLine(guess + " is too high");
                    }
                    else if (guess<number)
                    {
                        Console.WriteLine(guess + " is too low");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine(("You WIN!"));
                Console.WriteLine(("Guesses: " + guesses));

                Console.WriteLine("Would you like to play again (Y|N): ");
                response = Console.ReadLine();
                response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    {
                        playAgain= false;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Thanks for PLaying");


            Console.ReadKey();
        }
    }
}*/

/*using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low!");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing! ... I guess");

            Console.ReadKey();
        }
    }
}*/

//array
/*using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // String[] cars = new String[3]; declaration of an array of fixed size

            String[] cars = { "BMW", "Mustang", "Corvette" };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);

            cars[0] = "Tesla";
            cars[1] = "Audi";

            for (int i = 0;i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }


            Console.ReadKey();
        }
    }
}
*/

//methods
/*using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Bro";
            int age = 23;

            double x;
            double y;
            double z;
            double result;

            Console.WriteLine("Enter user input 1: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter user input 2: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter user input 3: ");
            z = Convert.ToDouble(Console.ReadLine());
            result = Multiply(x, y, z);
            Console.WriteLine(result);

            singHappyBirthday(name, age);
            singHappyBirthday(name, age);
            singHappyBirthday(name, age);


            Console.ReadKey();
        }
        static void singHappyBirthday(String nameOfBro, int hisAge)
        {
            Console.WriteLine("HPB");
            Console.WriteLine("HPB " + nameOfBro);
            Console.WriteLine("HPB " + hisAge);
            Console.WriteLine("HPB");

        }

        static double Multiply(double x, double y)
        {
            return x * y; ;
        }

        static double Multiply(double x, double y, double z)
        {
            return x * y * z; ;
        }
    }
}
*/

//Exception handling
/*using System.Diagnostics.CodeAnalysis;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            double result;


            try
            {
                Console.Write("Enter number 1: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("result: " + result);
            }

           
            catch (FormatException e)
            {
                Console.WriteLine("Enter only Numbers");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something Went Wrong!");
            }

            finally
            {
                Console.WriteLine("Thanks!");
            }

            Console.ReadKey();
        }
    }
}
*/


//ConditionalAttribute operator
/*namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp = 20;

            String message = (temp >= 15) ? "It's warm outside" : "It's cold outside";
            Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}*/

/*namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Messages.Hello();



            Console.ReadKey();
        }
    }
    public static class Messages
    {
        public static void Hello()
        {
            Console.WriteLine("Hello");
        }
        public static void Waiting()
        {
            Console.WriteLine("Wait");
        }
        public static void Bye()
        {
            Console.WriteLine("Bubye");
        }
    }
}
*/

//objects
/*using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            Human human2 = new Human();
            human1.name = "Mcb";
            human1.age = 23;
            human1.Eat();
            human1.Sleep();
            human2.name = "Morty";
            human2.age = 24;
            human2.Eat();
            human2.Sleep();


            Console.ReadKey();
        }
    }
    class Human
    {
        public String name;
        public int age;

       

        public void Eat()
        {
            Console.WriteLine(name + " is Eating");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is Sleeping");
        }
    }
}
*/

//constructors
/*
namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Mcb", 23);
            Human human2 = new Human("Morty", 24);
           
            human1.Eat();
            human1.Sleep();
            
            human2.Eat();
            human2.Sleep();


            Console.ReadKey();
        }
    }
    class Human
    {
        public String name;
        public int age;

        public Human (String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Eat()
        {
            Console.WriteLine(name + " is Eating");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is Sleeping");
        }
    }
}
*/

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number %2 == 0)
            {
                Console.WriteLine(number + " is a Even Number");
            }
            else
            {
                Console.WriteLine(number + " is a Odd Number");
            }

            Console.Beep();
            Console.ReadKey();
        }
    }
}




