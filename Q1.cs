//Instructions:
//Answer the following questions and implement the required code in C# targeting .NET Framework 4.7.2.
//1.	Class Definition:
//Define a simple class named Book with two public string properties: Title and Author.
//2.	Object Instantiation:
//How do you create an instance (an object) of the Book class you just defined? Provide an example.
//3.	Add a Method:
//Add a method to the Book class called DisplayDetails() that prints the book's title and author to the console.
//4.	Constructor Concept:
//What is a constructor ? Explain its purpose in a class.
//5.Implement a Constructor:
//Add a constructor to your Book class that takes title and author as parameters and sets the properties.
//6.	The this Keyword:
//What does the this keyword represent in C#? Modify your constructor to use this to distinguish between parameters and class properties (e.g., this.Title = title;).
//7.	Encapsulation (Private Fields):
//Modify the Book class so that the Title and Author fields are private.
//8.Encapsulation(Properties):
//How do you now access those private fields from outside the class? Create public properties (using get; set;) to expose the private _title and _author fields.
//9.Read - Only Property:
//Modify the Title property so it can only be set when the object is first created (in the constructor) but can be read publicly afterward. (Hint: Use a private set).
//10.Static vs.Instance Methods:
//What is the difference between a static method and an instance method?
//Create a MathHelper class with a static method Add(int a, int b) that returns the sum of its parameters.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{

    public class MathHelper
    {
        public static int Add(int a,int b)
        {
            return a + b;
        }
    }
    public class Book
    {
        private string Title { get; set; }
        private string Author { get; set; }
        public void DisplayDetails(string Title, string Author)
        {
            this.Title = Title;
            this.Author = Author;
            Console.WriteLine($"Book Title:{Title}");
            Console.WriteLine($"Author Name:{Author}");
        }
        public Book(string Title,string Author)
        {
            this.Title = Title;
            this.Author = Author;
            Console.WriteLine($"Book Title from Construction:{Title}");
            Console.WriteLine($"Author Name from Construction:{Author}");
        }

        static void Main(string[] args)
        {
            Book bk = new Book("SuperMan", "Kumar");
            bk.DisplayDetails("SuperHero", "Sumit");
            Console.WriteLine(MathHelper.Add(5, 6));
        }
    }
}
