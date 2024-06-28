class Program
{
    static void Main(string[] args)
    {
        MyDictionary<string, int> dictionary = new MyDictionary<string, int>();
        dictionary.Add("one", 1);
        dictionary.Add("two", 2);
        dictionary.Add("three", 3);

        try
        {
            Console.WriteLine($"Value for 'two': {dictionary["two"]}");
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine($"Total elements: {dictionary.Count}");
        foreach (var item in dictionary)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }
}
