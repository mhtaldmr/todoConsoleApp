using ProjectTwo.Actions;
using System;
using System.Collections.Generic;

namespace ProjectTwo
{
    internal partial class Program
    {
        public class BoardListeleme 
        {
            public static void List()
            {
                BoardLister.Listele(Board.TodoList, "Todo List");
                BoardLister.Listele(Board.InProgressList,"InProgress List");
                BoardLister.Listele(Board.DoneList, "Done List");
            }
        }
    }    
}
