namespace Example4;

internal class Program
{
    static void Main(string[] args)
    {
        MyStack stack = new MyStack(8);

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine($"Верхний элемент {stack.Peek()}");
        Console.WriteLine($"Размер самого стека {stack.Size()}");

        //Удаление 
        Console.WriteLine($"Удаление элемента:{stack.Pop()}");
        Console.WriteLine($"Удаление элемента:{stack.Pop()}");
        Console.WriteLine($"Размер самого стека {stack.Size()}");

        //Проверка на пустой стек 
        Console.WriteLine($"Стек пуст: {stack.IsEmpty()}");

        stack.Pop();
        Console.WriteLine($"Стек пуст: {stack.IsEmpty}");
    }
}
