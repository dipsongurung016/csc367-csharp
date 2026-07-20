class Program
{
    static void Main()
    {
        //convert double to int
        double a = 3.14;
        int b = Convert.ToInt32(a);
        Console.WriteLine(b.GetType());
        Console.WriteLine(a.GetType());

        //convert int to double
        int c=123;
        double d = Convert.ToDouble(c);
        Console.WriteLine(d.GetType());
        Console.WriteLine(c.GetType());

        //convert int to string
        int e=321;
        string f = Convert.ToString(e);
        Console.WriteLine(f.GetType());
        Console.WriteLine(e.GetType());

        //convert string to char
        string g = "$";
        char h = Convert.ToChar(g);
        Console.WriteLine(h.GetType());
        Console.WriteLine(g.GetType());

        //convert string to bool
        string i = "true";
        bool j = Convert.ToBoolean(i);
        Console.WriteLine(j.GetType());
        Console.WriteLine(i.GetType());
    }
}