// Fig. 19.5: ListTest.cs 
// Testing class List.
using System;
using LinkedListLibrary;

// class to test List class functionality
class ListTest
{
   static void Main()
   {
      var list = new List<double>(); // create List container

      // use List insert methods       
      list.InsertAtFront(30.45);
      list.Display();
      list.InsertAtFront(56.34);
      list.Display();
      list.InsertAtBack(23.78);
      list.Display();
      list.InsertAtBack(12.23);
      list.Display();

        // Test added method for assignment
        list.Search(12.23);
        // Test count method for assignment
        list.Count();
        // Test average method for assignment
        double ave = list.Avg();
        Console.WriteLine($"the average of the list is:{ave}");


        // remove data from list and display after each removal
        try
        {
         object removedObject = list.RemoveFromFront();
         Console.WriteLine($"{removedObject} removed");
         list.Display();

         removedObject = list.RemoveFromFront();
         Console.WriteLine($"{removedObject} removed");
         list.Display();

         removedObject = list.RemoveFromBack();
         Console.WriteLine($"{removedObject} removed");
         list.Display();

         removedObject = list.RemoveFromBack();
         Console.WriteLine($"{removedObject} removed");
         list.Display();
      }
      catch (EmptyListException emptyListException)
      {
         Console.Error.WriteLine($"\n{emptyListException}");
      }
   }
}

