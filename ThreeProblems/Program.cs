/*
* Name: Matthew Alan Alvis
* Course: CSCI 1250, Section 201
* Assignment: Lab 06, Three Short Problems
* Date: October 25, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

int choice = 0;

do
{
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

    if (choice == 1 || choice == 4)
    {
        System.Console.WriteLine("=== Exercise 1: The Grade Checker ===");
        //For exercise 1
    }

    if (choice == 2 || choice == 4)
    {
        System.Console.WriteLine("=== Exercise 2: The Dice Table ===");
        //For exersice 2
    }

    if (choice == 3 || choice == 4)
    {
        System.Console.WriteLine("=== Exercise 3: The Score Report ===");
        //for exercise 3
    }

} while (choice != 5);

Console.WriteLine("Goodbye");