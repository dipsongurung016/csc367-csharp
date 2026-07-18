class Program
{
    static void Main(string[] args)
    {
        int x; //declaration
        x = 10; // initialization
        
        int y = 20; // declaration and initialization
        
        int z = x + y; // declaration, initialization and assignment

        double cost = 21.5; //decimal number

        bool alive = false; //true or false

        char symbol = '@';

        string fname = "John";
        string lname = "Doe"; //string of characters

        string userName = symbol + fname + lname;

        Console.WriteLine("z = " + z); 
        Console.WriteLine("cost = " + cost);
        Console.WriteLine("are you alive = " + alive);
        Console.WriteLine("your symbol is "+symbol);
        Console.WriteLine("your first name is " + fname);
        Console.WriteLine("your last name is " + lname);
        Console.WriteLine("your username is " + userName);
    }
}