namespace Example4;

public class MyStack
{
    private int[] _stack; //Для хранения
    private int _top; //индекс верзнего элем
    private int _capacity; //вместимость

    public MyStack(int capacity)
    {
        _capacity = capacity;
        _stack = new int[_capacity];
        _top = -1;
    }

    //Сетод для добовления элем в стек
    public void Push(int value)
    {
        if (_top >= _capacity- 1)
        {
            throw new InvalidOperationException("Стек переполнен");
        }
        _stack[++_top] = value;
    }

    //метод для удаления элемента
    public int Pop()
    {
        if(_top  < 0)
        {
            throw new InvalidOperationException("Стек пустой");
        }
        return _stack[_top--];
    }

    //метод для получения верхнего без удаления 

    public int Peek()
    {
        if(_top < 0)
        {
            throw new InvalidOperationException("Стек пуст.");
        }
        return _stack[_top];
    }

    //Для проверки пуст ли стек
    public bool IsEmpty()
    {
        return _top < 0;  //если индекс меньше 0 то пуст 
    }

    //для получения размера стека 
    public int Size()
    {
        return _top + 1;
    }

}
