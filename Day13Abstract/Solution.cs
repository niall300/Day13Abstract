using System;
using System.Collections.Generic;
using System.IO;
//Task
//Given a Book class and a Solution class, write a MyBook class that does the following:

//Inherits from Book
//Has a parameterized constructor taking these parameters:
//string
//string
//int
//Implements the Book class' abstract display() method so it prints these  lines:
//Title, a space, and then the current instance's title.
//Author, a space, and then the current instance's .
//Price, a space, and then the current instance's .
//Note: Because these classes are being written in the same file,
//    you must not use an access modifier(e.g.: ) 
//    when declaring MyBook or your code will not execute.


//Sample Input

//The following input from stdin is handled 
//    by the locked stub code in your editor:

//The Alchemist
//Paulo Coelho
//248

//Sample Output

//The following output is printed by your display() method:

//Title: The Alchemist
//Author: Paulo Coelho
//Price: 248

namespace Day13Abstract
{
    abstract class Book
{

    protected String title;
    protected String author;

    public Book(String t, String a)
    {
        title = t;
        author = a;
    }
    public abstract void display();

    
}
    class MyBook : Book
        
    {
        int price;
        public MyBook(String t, String a, int p):base(t,a)
        {
            this.price = p;
        }
        public override void display()
        {
            //Title: The Alchemist
            //Author: Paulo Coelho
            //Price: 248
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price" + price);

        }
    }


    class Solution
    {
        static void Main(string[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
    
}
