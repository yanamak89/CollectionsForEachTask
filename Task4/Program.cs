using Task4;

class Program
{
    static void Main(string[] args)
    {
        MyList<int> list = new MyList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);

        int[] array = list.GetArray();
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}