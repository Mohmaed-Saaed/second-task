using System.Collections.Specialized;

namespace second_task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();

            int numberToAddToTheList = 0;
            int listSum = 0;
            int getLargestValueInTheList = 0; 
            int getSmallestValueInTheList = 0;
            int FindNumber = 0;

            char userInput = '\0';


            do
            {
                Console.WriteLine("_________________________________________________________");
                Console.WriteLine("\n\t\t\tMain Menu\n");

                Console.WriteLine("\tP - Print numbers");
                Console.WriteLine("\tA - Add a numbers");
                Console.WriteLine("\tM - Display The average of entered numbers");
                Console.WriteLine("\tS - Display The Smallest numbers");
                Console.WriteLine("\tL - Display The largest numbers");
                Console.WriteLine("\tF - find a number");
                Console.WriteLine("\tC - Clear list");
                Console.WriteLine("\tQ - Quit");
                Console.WriteLine("_________________________________________________________\n");
                userInput = char.ToUpper(Convert.ToChar(Console.ReadLine()));

                switch (char.ToUpper(userInput))
                {

                    case 'P':

                        char swapIndex = '\0';
                        int theFirstIndex = 0;
                        int theSecondIndex = 0;

                        if (list.Count > 0)
                        {
                            Console.Write("\n\t[");
                            for (int i = 0; i < list.Count; i++)
                                Console.Write($" {list[i]} ");

                            Console.WriteLine("]\n");
                        }
                        else
                            Console.WriteLine("\n\tthe list is empty please fill out your list\n");

                        // swap functionality
                        if (list.Count > 0)
                        {
                            Console.WriteLine("\n\t1- Do You want to swap indexes ? Y/N\n");

                            swapIndex = char.ToUpper(Convert.ToChar(Console.ReadLine()));

                            if (swapIndex == 'Y')
                            {
                                Console.WriteLine("\n\tSelect The first index: ");
                                theFirstIndex = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n\tSelect The second index: ");
                                theSecondIndex = Convert.ToInt32(Console.ReadLine());

                                int temp = 0;

                                temp = list[theFirstIndex];
                                list[theFirstIndex] = list[theSecondIndex];
                                list[theSecondIndex] = temp;

                                Console.WriteLine("\n\tNumbers have been successfully swapped");
                                Console.Write("\n\t[");
                                for (int i = 0; i < list.Count; i++)
                                    Console.Write($" {list[i]} ");
                                Console.WriteLine("]\n");

                            }
                        }

                        break;

                    case 'A':
                        Console.WriteLine("\n\tPlease enter a number to add: ");

                        numberToAddToTheList = Convert.ToInt32(Console.ReadLine());

                        bool isPlacedNumberInTheList = false;

                        for (int i = 0; i < list.Count; i++)
                            if (numberToAddToTheList == list[i])
                                isPlacedNumberInTheList = true;

                        if (!isPlacedNumberInTheList)
                        {
                            list.Add(numberToAddToTheList);
                            Console.WriteLine($"\t{numberToAddToTheList} Is added");
                        }
                        else
                        {
                            Console.WriteLine("\n\tPlaced number Is already In The list\n");
                        }
                        break;

                    case 'M':

                        if (list.Count > 0)
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                listSum += list[i];
                            }

                            Console.WriteLine($"\tThe average number is {listSum / list.Count}");
                        }
                        else
                        {
                            Console.WriteLine("\n\tNo list To get The Average\n");
                        }

                        break;

                    case 'L':

                        if (list.Count > 0)
                        {

                            getLargestValueInTheList = list[0];

                            for (int i = 0; i < list.Count; i++)
                            {

                                if (getLargestValueInTheList < list[i])
                                {
                                    getLargestValueInTheList = list[i];
                                }

                            }
                            Console.WriteLine($"\n\tThe largest number is {getLargestValueInTheList}");
                        }
                        else
                            Console.WriteLine("\n\t No numbers Is In The List To get The largest number\n");



                        break;

                    case 'S':

                        if (list.Count > 0)
                        {
                            getSmallestValueInTheList = list[0];

                            for (int i = 0; i < list.Count; i++)
                            {
                                if (getSmallestValueInTheList > list[i])
                                {
                                    getSmallestValueInTheList = list[i];
                                }
                            }
                            Console.WriteLine($"\n\tThe smallest number Is {getSmallestValueInTheList}");
                        }
                        else
                            Console.WriteLine("\n\t No numbers Is In The List To get The smallest number\n");

                        break;

                    case 'F':

                        if (list.Count > 0)
                        {
                            Console.WriteLine("\tPlease enter a number To search for index\n");
                            FindNumber = Convert.ToInt32(Console.ReadLine());
                            bool isNumberInTheList = false;

                            for (int i = 0; i < list.Count; i++)
                            {
                                if (FindNumber == list[i])
                                {
                                    Console.WriteLine($"\tThe number You Are looking for Is at index  {i}");
                                    isNumberInTheList = true;
                                    break;
                                }

                            }

                            if (!isNumberInTheList) Console.WriteLine("\tThe number Is not In The list\n");
                        }
                        else
                            Console.WriteLine("\n\t The list Is Empty");

                        break;

                    case 'C':

                        if (list.Count > 0)
                        {
                            list = new List<int>();
                            Console.WriteLine("\n\tList has been successfully cleared\n");
                        }
                        else
                            Console.WriteLine("\n\tThe list Is already empty\n");


                        break;

                    case 'Q':
                        Console.WriteLine("\n\tGood Bye");
                        break;

                    default:
                        Console.WriteLine("\n\tPlease enter a valid character\n");
                        break;
                }


            } while (userInput != 'Q');



        }
    }
}
