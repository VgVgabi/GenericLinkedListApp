using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;


namespace GenericLinkedListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool breakFlag = false;
            LinkedList<string> studentsNames = new LinkedList<string>();
            //
            while (!breakFlag)
            {
                try
                {
                    void GetLinkedList()
                    {
                        foreach (string student in studentsNames)
                            Console.WriteLine($"Current Linked List Row: {student}");
                    }
                    Console.WriteLine("\nWhat action would you like to take in Linked List?\na - Add\nd - Remove\ne - Enumerate\nb - Contains\nc - Clear\nq - Quit");
                    string userActionListiner = Console.ReadLine().ToLower();
                    // -->
                    switch (userActionListiner)
                    {
                        case "a":
                            Console.WriteLine("Set The Student Name:");
                            string studentName = Console.ReadLine();
                            Console.WriteLine("Where would you like to add? Set \"F\" beginning of the list or \"L\"at the end of the list?");
                            string userChoise = Console.ReadLine().ToLower();
                            // -->
                            switch (userChoise)
                            {
                                case "f":
                                    studentsNames.AddFirst(studentName);
                                    Console.WriteLine("Adding Operation Done!");
                                    GetLinkedList();
                                    break;
                                case "l":
                                    studentsNames.AddLast(studentName);
                                    Console.WriteLine("Adding Operation Done!");
                                    GetLinkedList();
                                    break;
                                default:
                                    Console.WriteLine("Wrong Chiose.");
                                    break;
                            }
                            break;
                        //
                        case "d":
                            if (studentsNames.Count > 0)
                            {
                                Console.WriteLine("Which index element would you like to remove? press \"F\" for the first name in list or press \"L\" for the last name in the list:");
                                string removeChoise = Console.ReadLine().ToLower();
                                // -->
                                switch (removeChoise)
                                {
                                    case "f":
                                        studentsNames.RemoveFirst();
                                        Console.WriteLine("Removing Operation Done!");
                                        GetLinkedList();
                                        break;
                                    case "l":
                                        studentsNames.RemoveLast();
                                        Console.WriteLine("Removing Operation Done!");
                                        GetLinkedList();
                                        break;
                                }
                            }
                            else
                                Console.WriteLine("There Is No Record In Linked List");
                            break;
                        //
                        case "e":
                            if (studentsNames.Count > 0)
                                GetLinkedList();
                            else
                                Console.WriteLine("There Is No Record In Linked List");
                            break;
                        //
                        case "b":
                            if (studentsNames.Count > 0)
                            {
                                Console.WriteLine("which item");
                                string studentSearch = Console.ReadLine();
                                bool searchStatus = studentsNames.Contains(studentSearch);
                                if (searchStatus == true)
                                    Console.WriteLine("The Name Exists In Linked List");
                                else
                                    Console.WriteLine("The Name NOT Exists In Linked List");
                            }
                            else
                                Console.WriteLine("There Is No Record In Linked List");
                            break;
                        //
                        case "c":
                            studentsNames.Clear();
                            Console.WriteLine("Clear Operation Done!");
                            break;
                        //
                        case "q":
                            breakFlag = true;
                            break;
                        //
                        default:
                            Console.WriteLine("Wrong Choise.");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("The Operation is failure!");
                }
            }
        }
    }
}