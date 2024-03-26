namespace Bukvi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] message = input.ToCharArray();

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] >= '0' && message[i] <= '9')
                {
                    message[i] = (char)(message[i] + 1);
                }
            }

            Console.WriteLine(new string(message));
        }
    }
}
