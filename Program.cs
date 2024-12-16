namespace Set3Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu o seire de numere despartite prin spatii: ");
            string input = Console.ReadLine();
            int[] vector = Array.ConvertAll(input.Split(' '),int.Parse);
            int sum = 0;
            
            for(int i = 0; i < vector.Length; i++)
            {
                sum += vector[i];
            }
            Console.WriteLine("Suma: " + sum);
        }
    }
}
