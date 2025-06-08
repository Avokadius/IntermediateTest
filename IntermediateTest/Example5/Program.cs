namespace Example5;
internal class Program
{
    static void Main(string[] args)
    {
        BaseClass disp = new DerivedClass1("Example", 42, "Extra Data");

        disp.Display();
    }
}
