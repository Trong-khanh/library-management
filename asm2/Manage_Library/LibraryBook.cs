using System;

namespace asm2.NewDirectory1
{
    public class LibraryBook : books
    {
        public string Language {get; set;}
        public string Semester {get; set;} 
        
        public LibraryBook()
        {
            
        }

        public LibraryBook(string name, string author, string producer, string yearPublish,
            float price, string language, string semester) : base(name, author, producer, yearPublish, price)
        {
            this.Language = language;
            this.Semester = semester;
        }

        public override void Input()
        {
            base.Input();
            
            Console.WriteLine("Enter Language: ");
            Language = Console.ReadLine();
            
            Console.WriteLine("Enter Semester: ");
            Semester = Console.ReadLine();
        }

        public override void Display()
        {
            base.Display();

            Console.WriteLine("Language: " + Language);
            Console.WriteLine("Semester: " + Semester);

        }
    }
}