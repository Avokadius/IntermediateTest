namespace Example2;

public class MyString
{
    private string _value;

    public MyString()
    {
        _value = string.Empty;
    }

    public  MyString(string value)
    {
            _value=value;
    }

    //Конструтор с двумя параметрами 
    public MyString(char[] character)
    {
        _value = new string(character);
    }

    //Метод для получения значения из строк 

    public string Getvalue()
    {
        return _value;
    }

    //Метод реверса строки 
    public string Revers()
    {
        char[] array = _value.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
}
