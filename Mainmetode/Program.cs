namespace Mainmetode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (string ord in args) {
                Console.WriteLine(ord);
            }
                Console.WriteLine(args.Length);

            
        }
    }
}