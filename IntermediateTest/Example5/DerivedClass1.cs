namespace Example5
{
    public class DerivedClass1 : BaseClass
    {
        private string additionalField;
        public DerivedClass1(string field1, int field2, string additionalField)
        : base(field1, field2)
        {
            this.additionalField = additionalField;
        }

        public override void Display()
        {
            Console.WriteLine($"DerivedClass1 - Field1: {field1}, Field2: {field2}, AdditionalField: {additionalField}");
        }
    }
}
