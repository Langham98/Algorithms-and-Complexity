using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ACproject1
{

    public class Variables
    {
        public static int Counter = 0;
        public static List<int> FoundValues; //set global variables
    }

    public class MainMenu
    {
        //Main Menu class and void, sets the initial states and gives the menu to select from
        public static void Main()
        {
            Console.WriteLine("Welcome to Algorithms and Complexity - Assessment 2 By Harry Langham");
            Console.WriteLine("How many elements would you like to address?");
            Console.WriteLine("1: 128");
            Console.WriteLine("2: 256"); //set up a main menu
             
            Console.WriteLine("q - Exit");

            string op = Console.ReadLine();
            switch (op)
            {
                //case statements to branch into the different file lengths
                case "1":
                    MainMenu128.MainMenu();
                    break;

                case "2":
                    MainMenu256.MainMenu();
                    break;



                case "q":
                    Environment.Exit(0);
                    break;
                //default case to send error and restart if an incorrect value is inputted and the quitting case
                default:
                    Console.WriteLine("**ERROR: Incorrect Value Entered**");
                    Main();
                    break;
            }
        }
    }
    public class MainMenu128
    //The 128 element length menu to choose the actual file from
    {
        public static void MainMenu()
        {
            Console.WriteLine("Welcome to Searching and Sorting - 128");

            Console.WriteLine("Select which Array to use...");
            Console.WriteLine("1: Close128");
            Console.WriteLine("2: Open128");
            Console.WriteLine("3: Change128");
            Console.WriteLine("4: Low128");
            Console.WriteLine("5: High128");
            Console.WriteLine("q - Exit");
            //setting up different variables for use in choosing the sorts and searches
            string PotentialSort;
            string PotentialSearch;
            string AscOrDec;
            double key;
            double n;
            int min = 0;
            string op = Console.ReadLine();
            switch (op)
            {
                //another case statement to choose the actual file and use it as the sorting
                case "1":

                    string Closepath128 = @"C:\Close_128.txt";

                    string[] closeArray128 = File.ReadAllLines(Closepath128);
                    //getting array from text file and converting it to a double array
                    double[] Close128 = new double[closeArray128.Length];
                    for (int i = 0; i < closeArray128.Length; i++)
                    {
                        Close128[i] = double.Parse(closeArray128[i]);
                        //parsing each element in turn using a for loop
                    }




                    Console.WriteLine("Array has been loaded in.");

                    Console.WriteLine("Which Sorting algorithm would you like to use?");
                    Console.WriteLine("1: Bubble Sort");
                    Console.WriteLine("2: Insertion Sort");
                    Console.WriteLine("3: Quick Sort");
                    Console.WriteLine("4: Heap Sort");
                    PotentialSort = Console.ReadLine();
                    n = Close128.Length;

                    //menu for the sorts 

                    //if statements to select the sort i'll be using
                    if (PotentialSort == "1")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();


                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Bubble Sort Ascending..."); //menu for ascending and desecnding
                            System.Threading.Thread.Sleep(2000);
                            BubbleSortAsc.bubblesort(Close128, n);

                            foreach (double i in Close128) //outputting the ascending values
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        } //outputting the operations and wiping the counter

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Bubble Sort Descending");
                            BubbleSortDec.bubblesort(Close128, n);

                            foreach (double i in Close128) //doing the same for descending
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        //using the bubble sort class to run the array and n value through it to gain a sorted array then outputting it via a foreach loop
                        Console.WriteLine("Sorted.");
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Close128.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Close128, key, min, max);

                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }

                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");

                            LinearSearch.linearSearch(Close128, key); //linear search of the array with positions outputted as well as the counters

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();

                        }

                        ///////////////////////////////////////////////////
                    }
                    if (PotentialSort == "2")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();


                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Insertion Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            InsertionSortAsc.insertionSort(Close128, n);

                            foreach (double i in Close128) //same fo the sort
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Insertion Sort Descending");
                            quicksortDec.QuickSort(Close128);

                            foreach (double i in Close128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        Console.WriteLine("Sorted.");
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Close128.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Close128, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }


                            BinarySearch.FoundValues.Clear();

                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Close128, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }


                            LinearSearch.FoundValues.Clear();

                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }

                    }

                    ///////////////////////////////////////////////////
                    if (PotentialSort == "3")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Quick Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            quicksortAsc.QuickSort(Close128);

                            foreach (double i in Close128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Quick Sort Descending");
                            quicksortDec.QuickSort(Close128);

                            foreach (double i in Close128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        Console.WriteLine("Sorted.");
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Close128.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Close128, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }


                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Close128, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                    }


                    ///////////////////////////////////////////////////
                    if (PotentialSort == "4")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Heap Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            HeapSortAsc.heapSort(Close128);

                            foreach (double i in Close128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Quick Sort Descending");
                            HeapSortDec.heapSort(Close128);

                            foreach (double i in Close128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        Console.WriteLine("Sorted.");
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Close128.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Close128, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }


                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Close128, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }

                        ///////////////////////////////////////////////////////////

                    }
                    /*  else
                      {
                          Console.WriteLine("**ERROR: Incorrect Value Entered**");
                          MainMenu();
                      }
  */

                    break;


                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                case "2":

                    string Openpath128 = @"C:\Open_128.txt";

                    string[] openArray128 = File.ReadAllLines(Openpath128); //reading from the next file and creating an array from its data. parsing it to being double

                    double[] Open128 = new double[openArray128.Length];
                    for (int i = 0; i < openArray128.Length; i++)
                    {
                        Open128[i] = double.Parse(openArray128[i]);

                    }




                    Console.WriteLine("Array has been loaded in.");

                    Console.WriteLine("Which Sorting algorithm would you like to use?");
                    Console.WriteLine("1: Bubble Sort");
                    Console.WriteLine("2: Insertion Sort");
                    Console.WriteLine("3: Quick Sort");
                    Console.WriteLine("4: Heap Sort");
                    PotentialSort = Console.ReadLine();
                    n = Open128.Length;



                    if (PotentialSort == "1")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();


                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Bubble Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            BubbleSortAsc.bubblesort(Open128, n);

                            foreach (double i in Open128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Insertion Sort Descending");
                            BubbleSortDec.bubblesort(Open128, n);

                            foreach (double i in Open128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        Console.WriteLine("Sorted...");
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Open128.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Open128, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 17)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                           
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Open128, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    if (PotentialSort == "2")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Insertion Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            InsertionSortAsc.insertionSort(Open128, n);

                            foreach (double i in Open128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Insertion Sort Descending");
                            InsertionSortDec.insertionSort(Open128, n);

                            foreach (double i in Open128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Open128.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Open128, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 17)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Open128, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    if (PotentialSort == "3")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Quick Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            quicksortAsc.QuickSort(Open128);

                            foreach (double i in Open128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Insertion Sort Descending");
                            quicksortDec.QuickSort(Open128);

                            foreach (double i in Open128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Open128.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Open128, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 17)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Open128, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }

                    if (PotentialSort == "4")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Heap Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            HeapSortAsc.heapSort(Open128);

                            foreach (double i in Open128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Insertion Sort Descending");
                            HeapSortDec.heapSort(Open128);

                            foreach (double i in Open128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Open128.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Open128, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 17)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Open128, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    else
                    {
                        Console.WriteLine("**ERROR: Incorrect Value Entered**");
                        MainMenu();
                    }
            

                    break;
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                case "3":

                    string Changepath128 = @"C:\Change_128.txt";

                    string[] changeArray128 = File.ReadAllLines(Changepath128);

                    double[] Change128 = new double[changeArray128.Length];
                    for (int i = 0; i < changeArray128.Length; i++)
                    {
                        Change128[i] = double.Parse(changeArray128[i]);

                    }




                    Console.WriteLine("Array has been loaded in.");

                    Console.WriteLine("Which Sorting algorithm would you like to use?");
                    Console.WriteLine("1: Bubble Sort");
                    Console.WriteLine("2: Insertion Sort");
                    Console.WriteLine("3: Quick Sort");
                    Console.WriteLine("4: Heap Sort");
                    PotentialSort = Console.ReadLine();
                    n = Change128.Length;

                    if (PotentialSort == "1")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();


                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Bubble Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            BubbleSortAsc.bubblesort(Change128, n);

                            foreach (double i in Change128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Insertion Sort Descending");
                            BubbleSortDec.bubblesort(Change128, n);

                            foreach (double i in Change128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Change128.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Change128, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 17)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Change128, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    if (PotentialSort == "2")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Insertion Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            InsertionSortAsc.insertionSort(Change128, n);

                            foreach (double i in Change128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Quick Sort Descending");
                            quicksortDec.QuickSort(Change128);

                            foreach (double i in Change128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Change128.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Change128, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 17)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Change128, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    if (PotentialSort == "3")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Quick Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            quicksortAsc.QuickSort(Change128);

                            foreach (double i in Change128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Quick Sort Descending");
                            quicksortDec.QuickSort(Change128);

                            foreach (double i in Change128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Change128.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Change128, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }

                            if (Variables.Counter == 17)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Change128, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }

                    if (PotentialSort == "4")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Heap Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            HeapSortAsc.heapSort(Change128);

                            foreach (double i in Change128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Insertion Sort Descending");
                            HeapSortDec.heapSort(Change128);

                            foreach (double i in Change128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Change128.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Change128, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 17)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Change128, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    else
                    {
                        Console.WriteLine("**ERROR: Incorrect Value Entered**");
                        MainMenu();
                    }


                    break;



                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                case "4":

                    string Lowpath128 = @"C:\Low_128.txt";

                    string[] lowArray128 = File.ReadAllLines(Lowpath128);

                    double[] Low128 = new double[lowArray128.Length];
                    for (int i = 0; i < lowArray128.Length; i++)
                    {
                        Low128[i] = double.Parse(lowArray128[i]);

                    }




                    Console.WriteLine("Array has been loaded in.");

                    Console.WriteLine("Which Sorting algorithm would you like to use?");
                    Console.WriteLine("1: Bubble Sort");
                    Console.WriteLine("2: Insertion Sort");
                    Console.WriteLine("3: Quick Sort");
                    Console.WriteLine("4: Heap Sort");
                    PotentialSort = Console.ReadLine();
                    n = Low128.Length;

                    if (PotentialSort == "1")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();


                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Bubble Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            BubbleSortAsc.bubblesort(Low128, n);

                            foreach (double i in Low128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Insertion Sort Descending");
                            BubbleSortDec.bubblesort(Low128, n);

                            foreach (double i in Low128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Low128.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Low128, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 17)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Low128, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    if (PotentialSort == "2")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Insertion Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            InsertionSortAsc.insertionSort(Low128, n);

                            foreach (double i in Low128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Quick Sort Descending");
                            quicksortDec.QuickSort(Low128);

                            foreach (double i in Low128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Low128.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Low128, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 17)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Low128, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    if (PotentialSort == "3")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Quick Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            quicksortAsc.QuickSort(Low128);

                            foreach (double i in Low128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Quick Sort Descending");
                            quicksortDec.QuickSort(Low128);

                            foreach (double i in Low128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Low128.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Low128, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 17)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Low128, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }

                    if (PotentialSort == "4")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Heap Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            HeapSortAsc.heapSort(Low128);

                            foreach (double i in Low128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Quick Sort Descending");
                            HeapSortDec.heapSort(Low128);

                            foreach (double i in Low128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Low128.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Low128, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 17)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Low128, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    else
                    {
                        Console.WriteLine("**ERROR: Incorrect Value Entered**");
                        MainMenu();
                    }


                    break;

                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                case "5":

                    string highPath128 = @"C:\High_128.txt";

                    string[] highArray128 = File.ReadAllLines(highPath128);

                    double[] High128 = new double[highArray128.Length];
                    for (int i = 0; i < highArray128.Length; i++)
                    {
                        High128[i] = double.Parse(highArray128[i]);

                    }


                    Console.WriteLine("Array has been loaded in.");
                    Console.WriteLine("Which Sorting algorithm would you like to use?");
                    Console.WriteLine("1: Bubble Sort");
                    Console.WriteLine("2: Insertion Sort");
                    Console.WriteLine("3: Quick Sort");
                    Console.WriteLine("4: Heap Sort");
                    PotentialSort = Console.ReadLine();
                    n = High128.Length;

                    if (PotentialSort == "1")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();


                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Bubble Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            BubbleSortAsc.bubblesort(High128, n);

                            foreach (double i in High128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Insertion Sort Descending");
                            BubbleSortDec.bubblesort(High128, n);

                            foreach (double i in High128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = High128.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(High128, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 17)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(High128, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    if (PotentialSort == "2")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Insertion Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            InsertionSortAsc.insertionSort(High128, n);

                            foreach (double i in High128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Quick Sort Descending");
                            quicksortDec.QuickSort(High128);

                            foreach (double i in High128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = High128.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(High128, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }

                            if (Variables.Counter == 17)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(High128, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    if (PotentialSort == "3")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Quick Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            quicksortAsc.QuickSort(High128);

                            foreach (double i in High128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Quick Sort Descending");
                            quicksortDec.QuickSort(High128);

                            foreach (double i in High128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = High128.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(High128, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 17)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(High128, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }

                    if (PotentialSort == "4")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Heap Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            HeapSortAsc.heapSort(High128);

                            foreach (double i in High128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Quick Sort Descending");
                            HeapSortDec.heapSort(High128);

                            foreach (double i in High128)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = High128.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(High128, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 17)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(High128, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                    }
                    else
                    {
                        Console.WriteLine("**ERROR: Incorrect Value Entered**");
                        MainMenu();
                    }

                    break;

                case "q":
                    Environment.Exit(0);
                    break;

                default:

                    MainMenu();
                    break;
            }
            Console.ReadLine();

        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////      

    }





    public class BubbleSortAsc
    {
        public static void bubblesort(double[] a, double n)
        {

            for (int i = 0; i < n - 1; i++)
            {
                Variables.Counter++;


                for (int j = 0; j < n - 1 - i; j++) //go through the array and switch the smallest values with the largest ones
                {
                    Variables.Counter++;

                    if (a[j + 1] < a[j])
                    {

                        double temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }

        }

    }

    public class BubbleSortDec
    {
        public static void bubblesort(double[] a, double n)
        {

            for (int i = 0; i < n - 1; i++)
            {

                Variables.Counter++;

                for (int j = 0; j < n - 1 - i; j++) //go through the array 
                {
                    Variables.Counter++;

                    if (a[j + 1] > a[j]) //switch the larger values with the smaller ones
                    {

                        double temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }

        }

    }


    public class quicksortAsc
    {
        public static void QuickSort(double[] data)
        {

            Quick_Sort(data, 0, data.Length - 1);
        }

        public static void Quick_Sort(double[] data, int left, int right)
        {
            int i, j;
            double pivot, temp;
            i = left;
            j = right;
            pivot = data[(left + right) / 2]; //create pivot halfway
            do
            {
                while ((data[i] < pivot) && (i < right)) i++;
                Variables.Counter++;
                while ((pivot < data[j]) && (j > left)) j--;
                Variables.Counter++;
                if (i <= j)
                {
                    temp = data[i];
                    data[i] = data[j]; //switch the values around
                    data[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            Variables.Counter++;
            if (left < j) Quick_Sort(data, left, j);

            if (i < right) Quick_Sort(data, i, right);

        }

    }

    public class quicksortDec
    {
        public static void QuickSort(double[] data)
        {

            Quick_Sort(data, 0, data.Length - 1);
        }

        public static void Quick_Sort(double[] data, int left, int right)
        {
            int i, j;
            double pivot, temp;
            i = left;
            j = right;
            pivot = data[(left + right) / 2]; //get the different values and create a pivot in the middle of the left and right
            do
            {
                while ((data[i] > pivot) && (i < right)) i++;
                Variables.Counter++;
                while ((pivot > data[j]) && (j > left)) j--;
                Variables.Counter++;
                if (i <= j) //if the left value is less than or equal to the right value then increment i, decrement j and switch the data[i] values and temp values around
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            Variables.Counter++;
            if (left < j) Quick_Sort(data, left, j);
            if (i < right) Quick_Sort(data, i, right);
        }

    }







    public class InsertionSortAsc
    {
        public static void insertionSort(double[] data, double n)
        // pre: 0 <= n <= data.length
        // post: values in data[0 … n-1] are in ascending order
        {
            int numSorted = 1; // number of values in place
            int index; // general index
            while (numSorted < n)
            {
                Variables.Counter++;
                // take the first unsorted value
                double temp = data[numSorted];
                // … and insert it among the sorted
                // … and insert it among the sorted
                for (index = numSorted; index > 0; index--)
                {
                    Variables.Counter++;
                    if (temp < data[index - 1])
                    {
                        Variables.Counter++;
                        data[index] = data[index - 1];
                    }
                    else
                    {
                        Variables.Counter++;
                        break;
                    }
                }
                // reinsert value
                data[index] = temp;
                numSorted++;
            }
        }

    }

    public class InsertionSortDec
    {
        public static void insertionSort(double[] data, double n)
        // pre: 0 <= n <= data.length
        // post: values in data[0 … n-1] are in ascending order
        {
            int numSorted = 1; // number of values in place
            int index; // general index
            while (numSorted < n)
            {
                Variables.Counter++;
                // take the first unsorted value
                double temp = data[numSorted];
                // … and insert it among the sorted
                // … and insert it among the sorted
                for (index = numSorted; index > 0; index++)
                {
                    Variables.Counter++;
                    if (temp > data[index - 1])
                    {
                        Variables.Counter++;
                        data[index] = data[index + 1];
                    }
                    else
                    {
                        Variables.Counter++;
                        break;
                    }
                }
                // reinsert value
                data[index] = temp;
                numSorted++;
            }
        }

    }




    public class HeapSortAsc
    {
        public static void heapSort(double[] Heap)
        {
            // pre: 0 <= n <= Heap.length
            // post: values in Heap[0 … n-1] are in ascending order
            int HeapSize = Heap.Length;
            int i;
            for (i = (HeapSize - 1) / 2; i >= 0; i--)
            {
                Variables.Counter++;
                Max_Heapify(Heap, HeapSize, i);
            }
            for (i = Heap.Length - 1; i > 0; i--)
            {
                Variables.Counter++;
                double temp = Heap[i];
                Heap[i] = Heap[0];
                Heap[0] = temp;
                HeapSize--;
                Max_Heapify(Heap, HeapSize, 0);
            }
        }

        private static void Max_Heapify(double[] Heap, int HeapSize, int Index)
        {
            int Left = (Index + 1) * 2 - 1;
            int Right = (Index + 1) * 2;
            int largest = 0;
            if (Left < HeapSize && Heap[Left] > Heap[Index])
            {
                Variables.Counter++;
                largest = Left;
            }
            else
            {
                Variables.Counter++;
                largest = Index;
            }
            if (Right < HeapSize && Heap[Right] > Heap[largest])
            {
                Variables.Counter++;
                largest = Right;
            }
            if (largest != Index)
            {
                Variables.Counter++;
                double temp = Heap[Index];
                Heap[Index] = Heap[largest];
                Heap[largest] = temp;
                Max_Heapify(Heap, HeapSize, largest);
            }
        }



    }

    public class HeapSortDec
    {
        public static void heapSort(double[] Heap)
        {
            // pre: 0 <= n <= Heap.length
            // post: values in Heap[0 … n-1] are in descending order
            int HeapSize = Heap.Length;
            int i;
            for (i = (HeapSize / 2) - 1; i >= 0; i--) //
            {
                Variables.Counter++;
                Min_Heapify(Heap, HeapSize, i);
            }
            for (i = HeapSize - 1; i >= 0; i--)
            {
                Variables.Counter++;
                double temp = Heap[0];
                Heap[0] = Heap[i];
                Heap[i] = temp;

                Min_Heapify(Heap, i, 0);
            }
        }

        private static void Min_Heapify(double[] Heap, int HeapSize, int Index)
        {
            int Left = (Index) * 2 + 1;
            int Right = (Index) * 2 + 2;
            int Smallest = Index;
            if (Left < HeapSize && Heap[Left] < Heap[Smallest])
            {
                Variables.Counter++;
                Smallest = Left;
            }
            else
            {
                Variables.Counter++;
                Smallest = Index;
            }
            if (Right < HeapSize && Heap[Right] < Heap[Smallest])
            {
                Variables.Counter++;
                Smallest = Right;
            }
            if (Smallest != Index)
            {
                Variables.Counter++;
                double temp = Heap[Index]; 
                Heap[Index] = Heap[Smallest];
                Heap[Smallest] = temp;
                Min_Heapify(Heap, HeapSize, Smallest);
            }
        }



    }





    public class BinarySearch
    {
        public static List<int> FoundValues = Variables.FoundValues;
        public static List<int> FoundValuesFinal = Variables.FoundValues;
        public static void binarySearch(double[] inputArray, double key, int min, int max)
        {
            FoundValues = new List<int>();
            if (min > max)
            {
                Variables.Counter++; //standard error catcher 
                Console.WriteLine("Error");
            }
            else
            {
                Variables.Counter++;
                int mid = (min + max) / 2;
                if (key == inputArray[mid]) //increment the counter and add the values to the list
                {
                    Variables.Counter++;


                    ++mid;
                    FoundValues.Add(mid);

                    for (int i = mid; i >= min; i--)
                    {
                        if (key == inputArray[mid])
                        {
                            mid--;
                            FoundValues.Add(mid); //uses a for loop to go throgh the indexes smaller and greater than the mid point to add them into the list
                        }
                    }

                    for (int i = mid; i <= max; i++)
                    {
                        if (key == inputArray[mid])
                        {
                            mid++;
                            FoundValues.Add(mid);
                            
                        }
                    }
                    

                }
                else if (key < inputArray[mid]) //move to halfway between the min value and the mid
                {
                    Variables.Counter++;
                    binarySearch(inputArray, key, min, mid - 1);

                }
                else //if the key value is greater than the mid then move to half way between the max value and the mid
                {
                    Variables.Counter++;
                    binarySearch(inputArray, key, mid + 1, max);

                }
            }
        }
    }

    public class LinearSearch
    {
        public static List<int> FoundValues = Variables.FoundValues; //Creating an instance to use adapted from the variables class
        public static void linearSearch(double[] data, double key)
        {
            FoundValues = new List<int>(); //creating an instance to use for the method
            int N = data.Length;
            for (int i = 0; i < N; i++)
            {
                Variables.Counter++; //going through the array and incrementing a counter as well as adding the index values to a list
                if (data[i] == key)
                {
                    Variables.Counter++;

                    FoundValues.Add(i);


                }

            }


            //Repeat of the 128 block but for the files containing 256 elements

        }
    }
    public class MainMenu256
    //The 256 element length menu to choose the actual file from
    {
        public static void MainMenu()
        {
            Console.WriteLine("Welcome to Searching and Sorting - 256");

            Console.WriteLine("Select which Array to use...");
            Console.WriteLine("1: Close256");
            Console.WriteLine("2: Open256");
            Console.WriteLine("3: Change256");
            Console.WriteLine("4: Low256");
            Console.WriteLine("5: High256");
            Console.WriteLine("q - Exit");
            //setting up different variables for use in choosing the sorts and searches
            string PotentialSort;
            string PotentialSearch;
            string AscOrDec;
            double key;
            double n;
            int min = 0;
            string op = Console.ReadLine();
            switch (op)
            {
                //another case statement to choose the actual file and use it as the sorting
                case "1":

                    string Closepath256 = @"C:\Close_256.txt";

                    string[] closeArray256 = File.ReadAllLines(Closepath256);
                    //getting array from text file and converting it to a double array
                    double[] Close256 = new double[closeArray256.Length];
                    for (int i = 0; i < closeArray256.Length; i++)
                    {
                        Close256[i] = double.Parse(closeArray256[i]);
                        //parsing each element in turn using a for loop
                    }




                    Console.WriteLine("Array has been loaded in.");

                    Console.WriteLine("Which Sorting algorithm would you like to use?");
                    Console.WriteLine("1: Bubble Sort");
                    Console.WriteLine("2: Insertion Sort");
                    Console.WriteLine("3: Quick Sort");
                    Console.WriteLine("4: Heap Sort");
                    PotentialSort = Console.ReadLine();
                    n = Close256.Length;

                    //menu for the sorts 

                    //if statements to select the sort i'll be using
                    if (PotentialSort == "1")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();


                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Bubble Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            BubbleSortAsc.bubblesort(Close256, n);

                            foreach (double i in Close256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Bubble Sort Descending");
                            BubbleSortDec.bubblesort(Close256, n);

                            foreach (double i in Close256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        //using the bubble sort class to run the array and n value through it to gain a sorted array then outputting it via a foreach loop
                        Console.WriteLine("Sorted.");
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Close256.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Close256, key, min, max);

                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 19)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");

                            LinearSearch.linearSearch(Close256, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();

                        }

                        ///////////////////////////////////////////////////
                    }
                    if (PotentialSort == "2")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();


                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Insertion Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            InsertionSortAsc.insertionSort(Close256, n);

                            foreach (double i in Close256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Insertion Sort Descending");
                            quicksortDec.QuickSort(Close256);

                            foreach (double i in Close256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        Console.WriteLine("Sorted.");
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Close256.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Close256, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 19)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();

                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Close256, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }


                            LinearSearch.FoundValues.Clear();

                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }

                    }

                    ///////////////////////////////////////////////////
                    if (PotentialSort == "3")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Quick Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            quicksortAsc.QuickSort(Close256);

                            foreach (double i in Close256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Quick Sort Descending");
                            quicksortDec.QuickSort(Close256);

                            foreach (double i in Close256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        Console.WriteLine("Sorted.");
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Close256.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Close256, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }

                            if (Variables.Counter == 19)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Close256, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                    }


                    ///////////////////////////////////////////////////
                    if (PotentialSort == "4")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Heap Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            HeapSortAsc.heapSort(Close256);

                            foreach (double i in Close256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Quick Sort Descending");
                            HeapSortDec.heapSort(Close256);

                            foreach (double i in Close256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        Console.WriteLine("Sorted.");
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Close256.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Close256, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 19)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Close256, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }

                        ///////////////////////////////////////////////////////////

                    }
                    /*  else
                      {
                          Console.WriteLine("**ERROR: Incorrect Value Entered**");
                          MainMenu();
                      }
  */

                    break;


                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                case "2":

                    string Openpath256 = @"C:\Open_256.txt";

                    string[] openArray256 = File.ReadAllLines(Openpath256);

                    double[] Open256 = new double[openArray256.Length];
                    for (int i = 0; i < openArray256.Length; i++)
                    {
                        Open256[i] = double.Parse(openArray256[i]);

                    }




                    Console.WriteLine("Array has been loaded in.");

                    Console.WriteLine("Which Sorting algorithm would you like to use?");
                    Console.WriteLine("1: Bubble Sort");
                    Console.WriteLine("2: Insertion Sort");
                    Console.WriteLine("3: Quick Sort");
                    Console.WriteLine("4: Heap Sort");
                    PotentialSort = Console.ReadLine();
                    n = Open256.Length;

                    if (PotentialSort == "1")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();


                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Bubble Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            BubbleSortAsc.bubblesort(Open256, n);

                            foreach (double i in Open256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Insertion Sort Descending");
                            BubbleSortDec.bubblesort(Open256, n);

                            foreach (double i in Open256)
                            {
                                Console.WriteLine(i);
                            }

                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        Console.WriteLine("Sorted...");
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Open256.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Open256, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 19)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Open256, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    if (PotentialSort == "2")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Insertion Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            InsertionSortAsc.insertionSort(Open256, n);

                            foreach (double i in Open256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Insertion Sort Descending");
                            InsertionSortDec.insertionSort(Open256, n);

                            foreach (double i in Open256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Open256.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Open256, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 19)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Open256, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    if (PotentialSort == "3")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Quick Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            quicksortAsc.QuickSort(Open256);

                            foreach (double i in Open256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Insertion Sort Descending");
                            quicksortDec.QuickSort(Open256);

                            foreach (double i in Open256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Open256.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Open256, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 19)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Open256, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }

                    if (PotentialSort == "4")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Heap Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            HeapSortAsc.heapSort(Open256);

                            foreach (double i in Open256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Insertion Sort Descending");
                            HeapSortDec.heapSort(Open256);

                            foreach (double i in Open256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Open256.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Open256, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }

                            if (Variables.Counter == 19)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Open256, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    else
                    {
                        Console.WriteLine("**ERROR: Incorrect Value Entered**");
                        MainMenu();
                    }


                    break;
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                case "3":

                    string Changepath256 = @"C:\Change_256.txt";

                    string[] changeArray256 = File.ReadAllLines(Changepath256);

                    double[] Change256 = new double[changeArray256.Length];
                    for (int i = 0; i < changeArray256.Length; i++)
                    {
                        Change256[i] = double.Parse(changeArray256[i]);

                    }




                    Console.WriteLine("Array has been loaded in.");

                    Console.WriteLine("Which Sorting algorithm would you like to use?");
                    Console.WriteLine("1: Bubble Sort");
                    Console.WriteLine("2: Insertion Sort");
                    Console.WriteLine("3: Quick Sort");
                    Console.WriteLine("4: Heap Sort");
                    PotentialSort = Console.ReadLine();
                    n = Change256.Length;

                    if (PotentialSort == "1")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();


                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Bubble Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            BubbleSortAsc.bubblesort(Change256, n);

                            foreach (double i in Change256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Insertion Sort Descending");
                            BubbleSortDec.bubblesort(Change256, n);

                            foreach (double i in Change256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Change256.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Change256, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 19)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Change256, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    if (PotentialSort == "2")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Insertion Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            InsertionSortAsc.insertionSort(Change256, n);

                            foreach (double i in Change256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Quick Sort Descending");
                            quicksortDec.QuickSort(Change256);

                            foreach (double i in Change256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Change256.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Change256, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }

                            if (Variables.Counter == 19)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Change256, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    if (PotentialSort == "3")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Quick Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            quicksortAsc.QuickSort(Change256);

                            foreach (double i in Change256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Quick Sort Descending");
                            quicksortDec.QuickSort(Change256);

                            foreach (double i in Change256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Change256.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Change256, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 19)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Change256, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }

                    if (PotentialSort == "4")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Heap Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            HeapSortAsc.heapSort(Change256);

                            foreach (double i in Change256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Insertion Sort Descending");
                            HeapSortDec.heapSort(Change256);

                            foreach (double i in Change256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Change256.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Change256, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 19)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Change256, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    else
                    {
                        Console.WriteLine("**ERROR: Incorrect Value Entered**");
                        MainMenu();
                    }


                    break;



                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                case "4":

                    string Lowpath256 = @"C:\Low_256.txt";

                    string[] lowArray256 = File.ReadAllLines(Lowpath256);

                    double[] Low256 = new double[lowArray256.Length];
                    for (int i = 0; i < lowArray256.Length; i++)
                    {
                        Low256[i] = double.Parse(lowArray256[i]);

                    }




                    Console.WriteLine("Array has been loaded in.");

                    Console.WriteLine("Which Sorting algorithm would you like to use?");
                    Console.WriteLine("1: Bubble Sort");
                    Console.WriteLine("2: Insertion Sort");
                    Console.WriteLine("3: Quick Sort");
                    Console.WriteLine("4: Heap Sort");
                    PotentialSort = Console.ReadLine();
                    n = Low256.Length;

                    if (PotentialSort == "1")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();


                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Bubble Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            BubbleSortAsc.bubblesort(Low256, n);

                            foreach (double i in Low256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Insertion Sort Descending");
                            BubbleSortDec.bubblesort(Low256, n);

                            foreach (double i in Low256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Low256.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Low256, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 19)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Low256, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    if (PotentialSort == "2")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Insertion Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            InsertionSortAsc.insertionSort(Low256, n);

                            foreach (double i in Low256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Quick Sort Descending");
                            quicksortDec.QuickSort(Low256);

                            foreach (double i in Low256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Low256.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Low256, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 19)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Low256, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    if (PotentialSort == "3")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Quick Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            quicksortAsc.QuickSort(Low256);

                            foreach (double i in Low256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Quick Sort Descending");
                            quicksortDec.QuickSort(Low256);

                            foreach (double i in Low256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Low256.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Low256, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 19)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Low256, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }

                    if (PotentialSort == "4")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Heap Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            HeapSortAsc.heapSort(Low256);

                            foreach (double i in Low256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Quick Sort Descending");
                            HeapSortDec.heapSort(Low256);

                            foreach (double i in Low256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = Low256.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(Low256, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 19)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(Low256, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    else
                    {
                        Console.WriteLine("**ERROR: Incorrect Value Entered**");
                        MainMenu();
                    }


                    break;

                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                case "5":

                    string highPath256 = @"C:\High_256.txt";

                    string[] highArray256 = File.ReadAllLines(highPath256);

                    double[] High256 = new double[highArray256.Length];
                    for (int i = 0; i < highArray256.Length; i++)
                    {
                        High256[i] = double.Parse(highArray256[i]);

                    }


                    Console.WriteLine("Array has been loaded in.");
                    Console.WriteLine("Which Sorting algorithm would you like to use?");
                    Console.WriteLine("1: Bubble Sort");
                    Console.WriteLine("2: Insertion Sort");
                    Console.WriteLine("3: Quick Sort");
                    Console.WriteLine("4: Heap Sort");
                    PotentialSort = Console.ReadLine();
                    n = High256.Length;

                    if (PotentialSort == "1")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();


                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Bubble Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            BubbleSortAsc.bubblesort(High256, n);

                            foreach (double i in High256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Insertion Sort Descending");
                            BubbleSortDec.bubblesort(High256, n);

                            foreach (double i in High256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = High256.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(High256, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 19)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(High256, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    if (PotentialSort == "2")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Insertion Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            InsertionSortAsc.insertionSort(High256, n);

                            foreach (double i in High256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Quick Sort Descending");
                            quicksortDec.QuickSort(High256);

                            foreach (double i in High256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = High256.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(High256, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 19)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(High256, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }
                    if (PotentialSort == "3")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Quick Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            quicksortAsc.QuickSort(High256);

                            foreach (double i in High256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Quick Sort Descending");
                            quicksortDec.QuickSort(High256);

                            foreach (double i in High256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }
                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = High256.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(High256, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 19)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(High256, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }


                    }

                    if (PotentialSort == "4")
                    {
                        Console.WriteLine("Ascending or descending?");
                        Console.WriteLine("1:Ascending");
                        Console.WriteLine("2:Descending");
                        AscOrDec = Console.ReadLine();

                        if (AscOrDec == "1")
                        {

                            Console.WriteLine("Sorting via Heap Sort Ascending...");
                            System.Threading.Thread.Sleep(2000);
                            HeapSortAsc.heapSort(High256);

                            foreach (double i in High256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        if (AscOrDec == "2")
                        {
                            Console.WriteLine("Sorting via Quick Sort Descending");
                            HeapSortDec.heapSort(High256);

                            foreach (double i in High256)
                            {
                                Console.WriteLine(i);
                            }
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                        }

                        Console.WriteLine("What Searching algorithm would you like to use?");
                        Console.WriteLine("1: Binary Search");
                        Console.WriteLine("2: Linear Search");
                        PotentialSearch = Console.ReadLine();
                        //searching menu
                        if (PotentialSearch == "1")
                        {
                            int max = High256.Length - 1;
                            Console.WriteLine("What value would you like to look for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Binary Search...");
                            //  System.Threading.Thread.Sleep(2000);
                            BinarySearch.binarySearch(High256, key, min, max);
                            foreach (int i in BinarySearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            if (Variables.Counter == 19)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }

                            BinarySearch.FoundValues.Clear();
                            //Outputting the position of only one element instead of all of them - 21.15 - 29/04/18
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                        if (PotentialSearch == "2")
                        {
                            Console.WriteLine("What value are you looking for?");
                            key = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Searching via Linear Search...");
                            LinearSearch.linearSearch(High256, key);

                            foreach (int i in LinearSearch.FoundValues)
                            {
                                Console.WriteLine("The Positions are: " + i);
                            }
                            LinearSearch.FoundValues.Clear();
                            Console.WriteLine("The total number of operations was " + Variables.Counter);
                            if (Variables.Counter > 127)
                            {
                                Console.WriteLine("Your Inputted value could not be found in the array");
                            }
                            Variables.Counter = 0;
                            Console.WriteLine("-------------------------------------------------");
                            MainMenu();
                        }
                    }
                    else
                    {
                        Console.WriteLine("**ERROR: Incorrect Value Entered**");
                        MainMenu();
                    }

                    break;

                case "q":
                    Environment.Exit(0);
                    break;

                default:

                    MainMenu();
                    break;
            }
            Console.ReadLine();

        }

    }
}

