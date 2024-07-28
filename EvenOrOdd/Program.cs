namespace EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if ((num & 1) == 1)
                Console.WriteLine($"this number {num} is Odd ");
            else
                Console.WriteLine($"this number {num} is Even ");
        }
    }
}
