namespace Example5;

public class DerivedClass2 : BaseClass
{
    private double additionalField;

    public DerivedClass2(string field1, int field2, double additionalField)
        : base(field1, field2)
    {
        this.additionalField = additionalField;
    }

    public override void Display()
    {
        Console.WriteLine($"DerivedClass2 - Field1: {field1}, Field2: {field2}, AdditionalField: {additionalField}");
    }
}
