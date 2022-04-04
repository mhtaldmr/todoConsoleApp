using System;
using System.Collections.Generic;
using static ProjectTwo.Card;

namespace ProjectTwo
{
    internal partial class Program
    {
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