/*
* Name: Matthew Alan Alvis
* Course: CSCI 1250, Section 201
* Assignment: Lab 06, Three Short Problems
* Date: October 25, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

using System.Net.Sockets;

int choice = 0;
Random rng = new Random(4000);

do
{
choice = 0;

    System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
    System.Console.WriteLine("1. The Grade Checker");
    System.Console.WriteLine("2. The Dice Table");
    System.Console.WriteLine("3. The Score Report");
    System.Console.WriteLine("4. All three");
    System.Console.WriteLine("5. Quit");

//Do While is so the menu can appear for the user to make their choice.


    while(choice < 1 || choice > 5)
    {
        System.Console.Write("Choose 1 through 5: ");
        choice = Convert.ToInt32(Console.ReadLine());

        if(choice < 1 || choice > 5) //This is incase the user cant read and needs a retry or 5
        {
            System.Console.WriteLine("Choose a number from 1 to 5.");
        }
    }

    System.Console.WriteLine(" ");

    if (choice == 1 || choice == 4)
    {
        System.Console.WriteLine("=== Exercise 1: The Grade Checker ==="); // didnt really notate this coming back to put notes
        System.Console.Write("Score: ");
        int score = Convert.ToInt32(Console.ReadLine());

        while(score <= 0 || score >= 101)
        {
            System.Console.WriteLine("A score must be between 0 and 100.");

            System.Console.Write("Score: ");
            score = Convert.ToInt32(Console.ReadLine());
        }

        if(score >= 90) //putting in order from A - F  so youdont get an F at 87%
        {
            System.Console.WriteLine(score + " earns a A");
        }

        else if(score >= 80)
        {
            System.Console.WriteLine(score + " earns a B");
        }

        else if(score >= 70)
        {
            System.Console.WriteLine(score + " earns a C");
        }

        else if(score >= 60)
        {
            System.Console.WriteLine(score + " earns a D");
        }

        else
        {
            System.Console.WriteLine(score + " earns a F");
        }

        System.Console.WriteLine(" ");
    }

    if (choice == 2 || choice == 4)
    {
        System.Console.WriteLine("=== Exercise 2: The Dice Table ===");


        //This setts the default roold and wins to 0 each time you start the exercise
        int rolls = 0;
        int wins = 0;
        string again;

        do
        {
            int die1 = rng.Next(1, 7); //rolling each die 1-6
            int die2 = rng.Next(1, 7);
            int total = die1 + die2; //the adding them together

            rolls++; //adds a roll each time so i can labe what roll we are on

            System.Console.Write("Roll " + rolls +": " + die1 + " and " + die2 + ", total " + total);

            if(die1 == 1 && die2 ==1)
            {
                System.Console.WriteLine(" Snake eyes."); //checks what you rolled and tells you if you get snake eyes...
            }

            else if(die1 == die2)
            {
                System.Console.WriteLine(" Doubles!"); // get double die...
            }

            else if(total == 7 || total == 11)
            {
                System.Console.WriteLine(" A winner."); // or win with a 7 or an 11.
                wins++;
            }
            else
            {
                System.Console.WriteLine(" "); //doesn't break the code. for some reason un known to me, I forgot this part and ".write" line above this as ".WriteLine".
            }                                  //Program was able to run although not how you wanted printed out. changing it to write make it not run at all till i added this else part.

            System.Console.Write("Roll again? (y/n) : ");
            again = Console.ReadLine() ?? "n"; //ends the exercise if you hit n

        }while(again == "y"); //rolls again if you hit y

        System.Console.WriteLine("You rolled " + rolls + " times and won " + wins + ".");
        System.Console.WriteLine(" ");
    }

    if (choice == 3 || choice == 4)
    {
        System.Console.WriteLine("=== Exercise 3: The Score Report ===");
        //for exercise 3
        System.Console.WriteLine(" ");
    }

} while (choice != 5);

Console.WriteLine("Goodbye.");
return;
//Can you let me know what it is imdoing wrong when oit comes to the .gitignore
//I think im doing it right but when i do my first commit they are still their.

// Sorry for being a bit late with this, I wil; Make sure this wont happen again
//also just want to put i think i alread did the final commit because it repeats already and end whenyou hit 5. will do touching up and verifying it works properly for a 5th commit