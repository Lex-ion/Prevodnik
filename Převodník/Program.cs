namespace Převodník
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zadej č. v des. soustavě");
            int vstup = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("zadej cílovou soustavu");
            int soustava = Convert.ToInt32(Console.ReadLine());
            int vystup = vstup;
            
            do
            {
                vystup=vstup%soustava;
                vstup=vstup/soustava;
                Console.WriteLine(vystup);
            } while (vstup!=0);

            Console.ReadLine();

        }
    }
}