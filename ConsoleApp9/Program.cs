namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> studenti = new Dictionary<int, string>();
            studenti.Add(56, "Mimi");
            studenti.Add(103,"Martin");
            studenti.Add(86, "Ana");

            Console.WriteLine("Vuvedeten ident.nomer: ");
            int n = int.Parse(Console.ReadLine());

            if (studenti.ContainsKey(n))
            {
                Console.WriteLine($"Student nomer {n} e {studenti[n]}");
            }
            else
            {
                Console.WriteLine("Nqma takuv student");
            }
        }
    }
}
