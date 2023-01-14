﻿namespace LinkedListSimple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Problems");

            bool check = true;

        Start:
            while (check)
            {
                Console.WriteLine("Please Select options :\n" +
                    "1)Elements Added in the Linked List using Add Method\n" +
                    "2)Elements Appended in the linked List to Last using Append Method\n" +
                    "3)Element Inserted At a Particular Position Using Insert \n" +
                    "4)Element Deleted from the list using pop Method\n");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Adding Elements as follows :");
                        LinkedListData list = new LinkedListData();
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        list.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        break;

                    case 2:

                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Adding Elements as follows :");
                        LinkedListData list1 = new LinkedListData();
                        list1.Add(56);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        list1.Append(30);
                        list1.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        list1.Append(70);
                        list1.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        list1.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        break;

                    case 3:

                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Adding Elements as follows :");
                        LinkedListData list2 = new LinkedListData();
                        list2.Add(56);
                        list2.Add(70);
                        //creating object of Node class and passing data 
                        Node node = new Node(30);
                        Console.WriteLine("Element inserted in between the list: {0}", node.data);
                        Console.WriteLine("So After inserting the Final list appears as :");
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        list2.Insert(56, node);
                        list2.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        break;

                    case 4:

                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("Adding Elements as follows :");
                        LinkedListData list3 = new LinkedListData();
                        list3.Add(56);
                        list3.Add(30);
                        list3.Add(70);
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        list3.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        Console.WriteLine("First Element Popped from the list");
                        list3.pop();
                        list3.Display();
                        Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
                        break;

                    default:
                        Console.WriteLine("Please select proper option");
                        break;

                        goto Start;

                }

            }

        }
    }
}
