using Task2;

class Program
{
    static void Main(string[] args)
    {
        MyList<int> list = new MyList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        
        Console.WriteLine($"Element at index 1: {list[1]}");
        
        Console.WriteLine($"Total elements: {list.Count}");

        Console.WriteLine("\nElements in the list: ");
        foreach (var item in list)
        {
            Console.WriteLine($"{item}");
            
        }
        
    }
}