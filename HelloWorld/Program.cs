using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //part one greetings statement
            //string messageOne = "";
            //messageOne = "Hello World!";
            //string messageTwo = "I am Spartacus";

            ////Part Two initial Spartacus attributes
            //int ageOne = 35;
            ////int ageTwo = 45;
            ////int ageThree = 80;
            //double heightOne = 72.50;
            ////double heightTwo = 91.45;
            //float weightOne = 210.0284606f;
            ////float weightTwo = 331.12345678f;
            //bool isGodLikeOne = true;
            //bool isGodLikeTwo = false;
            //char genderMale = 'M';
            //char genderFemale = 'F';

            ////Part three display variable values
            //Console.WriteLine(messageOne);
            //Console.WriteLine(messageTwo);

            ////Part four mathematical operator, bool and char examples
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(isGodLikeOne);
            //Console.WriteLine(genderMale);

            ////Part five variable reassignment
            //ageTwo = 70;
            //heightTwo = 35.12345f;
            //weightTwo = -429.1234573f;

            ////Part six mathematical operator examples
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(ageTwo / ageOne);
            //Console.WriteLine(ageTwo % ageOne);
            //Console.WriteLine(ageThree / ageOne);
            //Console.WriteLine(ageThree % ageOne);

            ////Part seven increment and decrement operator examples
            //ageTwo++;
            //Console.WriteLine(ageTwo);
            //ageTwo--;
            //Console.WriteLine(ageTwo);
            //Console.WriteLine("5" == "5");
            //Console.WriteLine(40 != 40);
            //Console.WriteLine(11 < 4);

            //Part eight concatenation example
            //Console.WriteLine(messageOne + " " + messageTwo + ".");
            //Console.WriteLine("I am " + ageOne + " years old, and yes it's " + isGodLikeOne + " I am godlike.");
            //Console.WriteLine("I weigh around " + weightOne + " pounds, and I am around " + heightOne + " inches tall.");
            //Console.WriteLine("I am {0} years old, and yes it's {1} I am godlike.", ageOne, isGodLikeOne);
            //Console.WriteLine("I weigh around {0} pounds, and I am around {1} inches tall.", weightOne, heightOne);

            //Part nine string equality examples
            //Console.WriteLine(messageTwo.Equals(messageOne));
            //Console.WriteLine(messageTwo.Equals("I am Spartacus"));
            //Console.WriteLine(ageOne.Equals(35));
            //string myGreeting = "Hello";
            //Console.WriteLine(myGreeting.ToUpper()); //prints "HELLO"
            //Console.WriteLine(myGreeting.ToLower()); //prints "hello"

            //Part ten string length examples
            //int messOneLength = messageOne.Length;
            //int messTwoLength = messageTwo.Length;

            //Console.WriteLine("The length of messageOne is " + messageOne.Length);
            //Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            //Console.WriteLine("The length of messageOne is " + messOneLength);
            //Console.WriteLine("The length of messageTwo is " + messTwoLength);

            //Part 11 conditionals
            //string city1 = "Vesuvius";
            //string city2 = "Nola";
            //string city3 = "Nuceria";
            //int city1Distance, city2Distance, city3Distance;

            ////Solicit user input example
            //Console.WriteLine("What is the distance to {0}?", city1);
            //city1Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to" + city2 +"?");
            //city2Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to Nuceria?");
            //city3Distance = int.Parse(Console.ReadLine());

            //if ((city1Distance <= 125) && ((city1Distance < city2Distance) && (city1Distance < city3Distance)))
            //{
            //    Console.WriteLine("We will march to Vesuvius");
            //}
            //if ((city2Distance <= 125) && ((city2Distance < city1Distance) && (city2Distance < city3Distance)))
            //{
            //    Console.WriteLine("We will march to Nola");
            //}
            //if ((city3Distance <= 125) && ((city3Distance < city1Distance) && (city3Distance < city2Distance)))
            //{
            //    Console.WriteLine("We will march to Nuceria");
            //}

            //Part 12
            //string city1 = "Vesuvius";
            //string city2 = "Nola";
            //string city3 = "Nuceria";
            //string vesuvius;
            //string nola;
            //string nuceria
            //Console.WriteLine("What is your rank soldier?");
            //string rank = Console.ReadLine();

            //Console.WriteLine("What is your age soldier?");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("What is your job soldier?");
            //string job = Console.ReadLine();

            //if ((rank == "officer") || (age <= 26))
            ////Solicit user input example
            //{
            //    Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //}
            //else if ((job == "cook") || (age >= 26))
            //{
            //    Console.WriteLine("My army has to eat. Pack your pots and pans.")
            //}
            //else 
            //{
            //    Console.WriteLine("Sorry you are staying home.");

            //switch (job)
            //   {
            //       case "infantry":
            //           Console.WriteLine("You will carry a sword");
            //       break;

            //       case "archer":
            //           Console.WriteLine("You will carry a bow and arrow");
            //       break;

            //       case "supply":
            //           Console.WriteLine("You will carry pots and pans");
            //       break;

            //       case "specialist":
            //           Console.WriteLine("You will opperate the catapault");
            //       break;

            //       default:
            //           Console.WriteLine("You will ride horseback");
            //           break;

            //Part 13 array examples
            //string[] foodList = new string[5];
            //foodList[0] = "Milk";
            //foodList[1] = "Fruit";
            //foodList[2] = "Meat";
            //foodList[3] = "Wine";
            //foodList[4] = "Bread";

            //Console.WriteLine(foodList[0]);
            //Console.WriteLine(foodList[1]);
            //Console.WriteLine(foodList[2]);
            //Console.WriteLine(foodList[3]);
            //Console.WriteLine(foodList[4]);

            //Console.WriteLine("{0},{1}, {2}, {4}, ", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4]);

            int[] foodAmount = new int[] { 1000, 1000, 2000, 10000, 1500 };
            //Console.WriteLine(foodAmount[0] + ", " + foodAmount[1] + ", " + foodAmount[2] + ", " + foodAmount[3] + ", " + foodAmount[4]);

            //Console.WriteLine(foodList.Length);

            //string[] elements = messageTwo.Split(' ');
            //Console.WriteLine(elements[0]);
            //Console.WriteLine(elements[1]);
            //Console.WriteLine(elements[2]);

            //String myName = "Sue";
            //char[] letters = myName.ToCharArray();

            //Console.WriteLine(letters[0]);
            //Console.WriteLine(letters[1]);
            //Console.WriteLine(letters[2]);

            //string[] aboutMom = new string[3];
            //aboutMom[0] = "Writer and Speaker";
            //aboutMom[1] = "Likes Bourbon, Old Grand Dad, specifically";
            //aboutMom[2] = "Bad Cook";

            //Console.WriteLine(aboutMom[0]);
            //Console.WriteLine(aboutMom[1]);
            //Console.WriteLine(aboutMom[2]);

            //Part 14 Loops

            //string action = " ";
            //while (action != "exit")
            //{
            //    Console.WriteLine("What is your rank soldier?");
            //    string rank = Console.ReadLine();

            //    Console.WriteLine("What is your age soldier?");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("What is your job soldier?");
            //    string job = Console.ReadLine();

            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //    }
            //    else if ((job == "cook") || (age >= 26))
            //    {
            //        Console.WriteLine("My army has to eat. Pack your pots and pans");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry you are staying home.");
            //    }
            //    Console.WriteLine("Add another? Type exit to quit");
            //    action = Console.ReadLine();
            //}

            //do while example....
            //string action = " ";
            //do
            //{
            //    Console.WriteLine("What is your rank soldier?");
            //    string rank = Console.ReadLine();

            //    Console.WriteLine("What is your age soldier?");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("What is your job soldier?");
            //    string job = Console.ReadLine();

            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //    }
            //    else if ((job == "cook") || (age >= 26))
            //    {
            //        Console.WriteLine("My army has to eat. Pack your pots and pans");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry you are staying home.");
            //    }
            //    Console.WriteLine("Add another? Type exit to quit");
            //    action = Console.ReadLine();
            //} while (action != "exit");

            for (int i = 0; i < foodAmount.Length; i++)
            {
                Console.WriteLine(i);
            }




        }
    }



    }

