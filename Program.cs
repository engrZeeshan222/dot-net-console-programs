using System;
// Book struct
public struct Book
{
    public Book(int Id)
    {
        Console.WriteLine($"value of id : {Id}");
    }

    public string Title;
    public string Author;
    public decimal Price;
    public short Year;
}

// enum
public enum WeekDays { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

// Set Properties
class Person
{
    public string name;
    public int age;
    public Person(int age)
    {
        this.age =age; 
    }
    public string Name
    {
        get { return this.name; }
        set { this.name = value + "Mian"; }
    }
}
class Hello
{
    static void Main()
    {
        Console.WriteLine("Hello, C# World!");
        Console.ReadKey();

    //C# Types
        Console.WriteLine("Types Sample");

        // Declare int variable
        int i = 34;
        // char variable
        char c = 'm';
        // float variable
        float per = 6.8f;
        // object variable
        object o = c;
        // string varialbe
        string name = "Mahesh Chand";
        // Use i in an operation
        int counter = i + 1;
        /* Use c in a condition. Check if the value of c is 'm'
        the print c and counter */
        if (c == 'm')
        {
            Console.WriteLine("i is {0}:", i);
            Console.WriteLine("counter is {0}:", counter);
            Console.WriteLine("c is {0}:", c);
            Console.WriteLine("name is {0}:", name);
            Console.WriteLine(counter);
        }

        Console.ReadKey();

        // Struct 
        Console.WriteLine("Struct Sample!");

        // Create a Book object
        Book myBook = new Book();
        myBook.Title = "Simplified C#";
        myBook.Author = "Mahesh Chand";
        myBook.Price = 45.95M;
        myBook.Year = 2017;

        Console.WriteLine($"Book {myBook.Title} was written by {myBook.Author}" +
           $" in {myBook.Year}. Price is {myBook.Price}");

        Console.ReadKey();
        
        // attributes 
        Person myPerson = new Person(23);
        myPerson.Name = "Zeeshan";
        Console.WriteLine(myPerson.name);
        Console.WriteLine(myPerson.age);
        Console.WriteLine(myPerson.Name);


        // call to struct
        Book myBook1 = new  Book(23);

        Console.ReadKey();

        // switch and goto
        Console.WriteLine("What is your name? ");
        string name1 = Console.ReadLine();
        switch (name1)
        {
            case "Mahesh":
                Console.WriteLine("My name is Mahesh.");
                goto case "Chand";
            case "Chand":
                Console.WriteLine(@"Chand is my last name.");
                break;
            case "Neel":
                Console.WriteLine("My name is Neel. ");
                break;
            default:
                break;
        }
        Console.ReadKey();

        //------------------------------------------------------- Arrays -------------------------------------------
        // Array of odd numbers
        int[] oddArray = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
        // Loop through array items
        foreach (int num in oddArray)
        {
            Console.WriteLine(num);
            // Don't read any number after 15
            if (num == 15) break;
        }
        Console.ReadKey();

    }
}