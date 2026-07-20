class Program
{
    static void Main()
    {
        double a = 3.14;
        int b = Convert.ToInt32(a);
        //int c = 10;
        Console.WriteLine(b.GetType());
        Console.WriteLine(a.GetType());

        int c=123;
        double d = Convert.ToDouble(c);
        Console.WriteLine(d.GetType());
        Console.WriteLine(c.GetType());

        int e=321;
        string f = Convert.ToString(e);
        Console.WriteLine(f.GetType());
        Console.WriteLine(e.GetType());
    }
}