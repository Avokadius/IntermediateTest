namespace Example2;
internal class Program
{
    static void Main(string[] args)
    {
        //Конструктор по умолчанию 
        MyString mystring1 = new MyString();
        Console.WriteLine(mystring1.Getvalue());

        //Конструктор с одним параметром 
        MyString mystring2 = new MyString("Hello my name is Denis");
        Console.WriteLine(mystring2.Getvalue());

        //Реверс 
        string revers = mystring2.Revers();
        Console.WriteLine(revers);

        char[] chars = { 'a', 'b', 'c' };
        MyString mystring3 = new MyString(chars);
        Console.WriteLine(mystring3.Getvalue());
    }
}
