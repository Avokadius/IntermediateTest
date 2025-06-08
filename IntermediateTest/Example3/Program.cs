namespace Example3;

internal class Program
{
    static void Main(string[] args)
    {
        DateTime date = new DateTime(2000, 3, 6);
        string result = date.ToCustomString();
        Console.WriteLine(result);
    }
}
