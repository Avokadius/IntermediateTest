namespace Example5;
public class BaseClass
{
    protected string field1;
    protected int field2;

    public BaseClass(string field1, int field2)
    {
        this.field1 = field1;
        this.field2 = field2;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Field1: {field1}, Field2: {field2}");
    }
}
