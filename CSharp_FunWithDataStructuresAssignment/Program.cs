using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_FunWithDataStructuresAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int end = 0;
            string choice = string.Empty;
            bool IsValidChoice = false;

            while (!IsValidChoice)
            {
                Console.WriteLine("Welcome to Fun with Data Structures!  Please choose your Data Strucuture from the list below.");
                Console.WriteLine("[1]  Array");
                Console.WriteLine("[2]  List");
                Console.WriteLine("[3]  Stack");
                Console.WriteLine("[4]  Queue");
                Console.WriteLine("[5]  Linked List");
                Console.WriteLine("Your choice?");

                choice = Console.ReadLine();
                if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5")
                {
                    Console.WriteLine("Invalid choice entered.  Please enter a valid choice.");
                }
                else
                {
                    IsValidChoice = true;
                }
            }
            Console.WriteLine("Great!  Now please enter your starting number.");
            try
            {
                start = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error encountered: {ex.Message}.");
                Console.ReadKey();
                return;
            }
            
            Console.WriteLine("Next, please enter your ending number.");
            try
            {
                end = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error encountered: {ex.Message}.");
                return;
            }

            switch (choice)
            {
                case "1":
                    DoArrayWork(start, end);
                    break;
                case "2":
                    DoListWork(start, end);
                    break;
                case "3":
                    DoStackWork(start, end);
                    break;
                case "4":
                    DoQueueWork(start, end);
                    break;
                case "5":
                    DoLinkedListWork(start, end);
                    break;
                default:
                    Console.WriteLine($"Your entry - {choice} - is not a valid selection.");
                    break;
            }

            Console.WriteLine("All done!  Press any key to end.");
            Console.ReadKey();          
        }

        private static void DoArrayWork(int startingNumber, int endingNumber)
        {
            //Array functionality
            Console.WriteLine("Array functionality");

            //Have to add 1 for the length since an array of, say, 5 thru 10 actually contains 6 numbers!
            int arraySize = (endingNumber - startingNumber) + 1;
            int[] myArray = new int[arraySize];
            int arrayPosition = 0;
            for (int i = startingNumber; i <= endingNumber; i++)
            {
                myArray[arrayPosition] = i;
                arrayPosition++;
            }

            //Now write the array contents to the console
            for (int j = 0; j < myArray.Length; j++)
            {
                Console.WriteLine($"Array contents at position {j}:  {myArray[j]}.");
            }

            Console.WriteLine("Please enter a comma-separated list of values to put into an array.");
            string[] valuesArray = Console.ReadLine().Split(',');
            foreach (string s in valuesArray)
            {
                Console.WriteLine($"Values Array member: {s}");
            }
        }

        private static void DoListWork(int startingNumber, int endingNumber)
        {
            //List functionality
            List<int> numberList = new List<int>();

            for (int i = startingNumber; i <= endingNumber; i++)
            {
                numberList.Add(i);
            }

            foreach (int n in numberList)
            {
                Console.WriteLine($"List item: {n}");
            }

            Console.WriteLine($"Number of items in the list: {numberList.Count()}");
        }

        private static void DoStackWork(int startingNumber, int endingNumber)
        {
            //Stack (Generic version) functionality
            Stack<int> numberStack = new Stack<int>();

            for (int i = startingNumber; i <= endingNumber; i++)
            {
                numberStack.Push(i);
            }

            foreach (int s in numberStack)
            {
                Console.WriteLine($"Stack item: {s}");
            }
        }

        private static void DoQueueWork(int startingNumber, int endingNumber)
        {
            //Queue functionality
            Queue<int> numberQueue = new Queue<int>();

            for (int i = startingNumber; i <= endingNumber; i++)
            {
                numberQueue.Enqueue(i);
            }

            //Save the count because the .count changes as you dequeue
            int queueOriginalCount = numberQueue.Count;

            for (int q = 0; q < queueOriginalCount; q++)
            {
                Console.WriteLine($"Queue item: {numberQueue.Dequeue()}");
            }
        }

        private static void DoLinkedListWork(int startingNumber, int endingNumber)
        {
            //Linked List functionality
            LinkedList<int> numberLinkedList = new LinkedList<int>();

            for (int i = startingNumber; i <= endingNumber; i++)
            {
                numberLinkedList.AddLast(i);
            }

            PrintLinkedList(numberLinkedList);

            Console.WriteLine("What number would you like to remove from the Linked List?");
            int numberToRemove = Convert.ToInt32(Console.ReadLine());

            numberLinkedList.Remove(numberToRemove);

            Console.WriteLine($"Linked list after removing {numberToRemove}:");
            PrintLinkedList(numberLinkedList);
        }

        private static void PrintLinkedList(LinkedList<int> numLinkedList)
        {
            foreach (int l in numLinkedList)
            {
                Console.WriteLine($"Linked List item: {l}");
            }
        }
    }
}
