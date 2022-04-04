using System;
using System.Collections.Generic;
using static ProjectTwo.Card;

namespace ProjectTwo
{
    internal partial class Program
    {
        //public static List<Card> TodoList = new();
        //public static List<Card> DoneList = new();
        //public static List<Card> InProgressList = new();

        static void Main()
        {
            SampleData.Add(Board.TodoList);

            var input=0;
            while(input != 5)
            {
                StartMenu.List();
                input = int.Parse(Console.ReadLine());

                Menu.Selector(input);
            }            
        }
    }
}