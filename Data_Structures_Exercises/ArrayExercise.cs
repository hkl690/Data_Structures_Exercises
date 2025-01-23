using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Exercises
{
    public class ArrayExercise
    {
        private int[] array;

        // Constructor to initialize the array
        public ArrayExercise()
        {
            array = new int[0];
        }

        /// <summary>
        /// Method to add an element to the end of the array (case 1)
        /// </summary>  
        public void AddToEnd()
        {
            Console.WriteLine("Enter the number to add to the array: ");
            int newElement;

            // Validate user input
            while (!int.TryParse(Console.ReadLine(), out newElement))
            {
                Console.WriteLine("Invalid input. Please enter a valid number: ");
            }

            // Create a new array with an extra space
            int[] newArray = new int[array.Length + 1];

            // Copy the elements from the old array to the new array
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            // Add the new element to the end of the new array
            newArray[array.Length] = newElement;

            // Update the reference to the new array
            array = newArray;

            Console.WriteLine($"Element {newElement} added to the end of the array.");
        }

        /// <summary>
        /// Method to display the array (case 4)
        /// </summary>
        public void DisplayArray()
        {
            if (array.Length == 0)
            {
                Console.WriteLine("The array is empty.\n");
                return;
            }
            Console.WriteLine("These are the elements in your array.");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Index {i}: {array[i]}");
            }
            Console.WriteLine();
        }


        public void ClearArray()
        {
            array = new int[0];
            Console.WriteLine("Array has been cleared.\n");
        }

    }
}