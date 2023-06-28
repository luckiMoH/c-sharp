//var number = 123;
//var count = 10;
//var totalPrice = 12.95f;
//var character = 'A';
//var firstName = "Mateusz";
//var isWorking = true;
//Console.WriteLine(number);
//Console.WriteLine(count);
//Console.WriteLine(totalPrice);
//Console.WriteLine(character);
//Console.WriteLine(firstName);
//Console.WriteLine(isWorking);

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
        Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

        const float Pi = 3.14f;
        Console.WriteLine(Pi);
    }
}