namespace Zad.Podniz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string largerString = Console.ReadLine();
            string subString = Console.ReadLine();

            int count = 0;
            int index = -1;

            while ((index = largerString.IndexOf(subString, index + 1)) != -1)
            {
                count++;
            }

            Console.WriteLine($"Podniz{subString} e {count} po-gilqm ot nego.");
        }
    }
}
