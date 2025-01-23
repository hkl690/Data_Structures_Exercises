using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        /// Method to insert an element at a given location (case 2)
        /// </summary>
        public void InsertElement(int index, int newValue)
        {
            if (index < 0 || index > array.Length)
            {
                Console.WriteLine("Invalid index.");
                return;
            }
            // Create a new array with an extra space
            int[] newArray = new int[array.Length + 1];

            // Copy the elements from the old array to the new array
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            // Insert the new element at the specified index
            newArray[index] = newValue;

            // Copy the remaining elements from the old array to the new array
            for (int i = index; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }
            // Update the reference to the new array
            array = newArray;
            Console.WriteLine($"Inserted element {newValue} at index {index}.");
        }

        /// <summary>
        /// Method to delete the element at a given location (case 3)
        /// </summary>
        public void DeleteElement(int index)
        {
            if (index < 0 || index >= array.Length)
            {
                Console.WriteLine("Invalid index.");
                return;
            }
            // Create a new array with one less space
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            // Copy elements after the deleted index
            for (int i = index + 1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];
            }
            // Update the reference to the new array
            array = newArray;

            Console.WriteLine($"Element at index {index} has been deleted.");

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
            /*
            Console.WriteLine("These are the elements in your array.");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Index {i}: {array[i]}");
            }*/
            Console.WriteLine("Array elements: [" + string.Join(", ", array) + "]\n");
        }

        /// <summary>
        /// Method to display the count of the total number of elements in the array (case 5)
        /// </summary>
        public void DisplayCount()
        {
            int count = array.Length;
            Console.WriteLine($"The array contains {count} elements.");
        }

        /// <summary>
        /// Method to clear (initialize) the array (case 6)
        /// </summary> 
        public void ClearArray()
        {
            array = new int[0];
            Console.WriteLine("Array has been cleared.");
        }

    }
}