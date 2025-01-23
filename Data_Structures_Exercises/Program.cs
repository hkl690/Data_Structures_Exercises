using System;

namespace Data_Structures_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayExercise arrayExercise = new ArrayExercise();
            string UserInput1;
            int Option = 0;
            bool IsRunning = true;

            // Loop for both menu display and validation
            while (IsRunning)
            { 
            Console.WriteLine("An menu of options: \n");
            Console.WriteLine("Press 1 to add to the end of the array.\n" +
                "Press 2 to insert an element at a given location.\n" +
                "Press 3 to delete an element from a given location." +
                "Press 4 to show all the array elements.\n" +
                "Press 5 to display the count of the total number of elements.\n" +
                "Press 6 to clear (initialize) an array.\n" +
                "Press 7 to exit the program.\n");

                Console.WriteLine("Please enter a number between 1 and 7: ");
                UserInput1 = Console.ReadLine();

                // Try to parse the input to an integer
                if (int.TryParse(UserInput1, out Option) && Option >= 1 && Option <= 7)
                {
                    Console.WriteLine($"You entered: {Option}");

                    if (Option == 7)
                    {
                        IsRunning = false; // Exit the program.
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                }
            }
        }
    }
}

