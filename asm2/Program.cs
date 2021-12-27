using System;
using System.Collections.Generic;
using asm2.NewDirectory1;

namespace asm2
{
    class test 
    {
        static void Main(string[] args)
        {
            List<LibraryBook> libraryBooks = new List<LibraryBook>();
            int choose;
            do
            {
                showMenu();
                choose = Int32.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Input(libraryBooks);
                        break;
                    case 2:
                        Display(libraryBooks);
                        break;
                    case 3:
                        SearchingByNameOfAuthor(libraryBooks);
                        break;
                    case 4:
                        SearchingByNameOfBook(libraryBooks);
                        break;
                    case 5:
                        Delete(libraryBooks);
                        break;
                    case 6:
                        Console.WriteLine("End program ");
                        break;
                    default:
                        Console.WriteLine("Enter error!!!!");
                        break;
                }
            } while (choose != 6);
        }

        static void Delete(List<LibraryBook> libraryBooks)
        {
            Console.WriteLine("Enter Name need find to delete");
            string Searching = Console.ReadLine();
            
            var founded = 0; // flag( cờ )
            
            for (int i = 0; i < libraryBooks.Count; i++)
            {
                if (libraryBooks[i].Name.Equals(Searching))
                {
                    founded++;
                    libraryBooks.Remove(libraryBooks[i]);
                    Console.WriteLine("Delete successfully!!!");
                }
            }

            if (founded == 0)
            {
                Console.WriteLine("Not founded ");
            }
        }
        
        static void SearchingByNameOfAuthor(List<LibraryBook> libraryBooks)
        {
            Console.WriteLine("Enter Name Author need find ");
            string Searching = Console.ReadLine();

            for (int i = 0; i < libraryBooks.Count; i++)
            {
                if (libraryBooks[i].Author.Equals(Searching))
                {
                    libraryBooks[i].Display();
                }
            }
        }

        static void SearchingByNameOfBook(List<LibraryBook>libraryBooks)
        {
            Console.WriteLine("Enter Book need find ");
            string Searching = Console.ReadLine();

            for (int i = 0; i < libraryBooks.Count; i++)
            {
                if (libraryBooks[i].Name.ToLower().Trim().Equals(Searching.ToLower().Trim()))
                {
                    libraryBooks[i].Display();
                }
            }
        }

        static void Display(List<LibraryBook> libraryBooks)
        {
            for (int i = 0; i < libraryBooks.Count; i++)
            {
                libraryBooks[i].Display();
            }
        }

        static void Input(List<LibraryBook> libraryBooks)
        {
            Console.WriteLine("Enter the number of books to add");
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                LibraryBook book = new LibraryBook();
                book.Input();
                
                libraryBooks.Add(book);
            }
        }
        static void showMenu()
        {
            Console.WriteLine("1:   Emter information of book");
            Console.WriteLine("2:   Show information entered");
            Console.WriteLine("3:   Find book by name author");
            Console.WriteLine("4:   Find book by name ");
            Console.WriteLine("5:   Delete book by name ");
            Console.WriteLine("6:   Exit.");
            Console.WriteLine("Option: ");
        }
    }
}