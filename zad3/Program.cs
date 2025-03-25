namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> slujiteli = new SortedDictionary<int, string>();

            while(true)
            {
                string vhod = Console.ReadLine();
                if (vhod != "end")
                {
                    int kluch = int.Parse(Console.ReadLine());
                    slujiteli[kluch] = vhod;
                }
                else
                {
                    break;
                }
            }
            foreach (var sl in slujiteli)
            {
                Console.WriteLine($"Slujitel nomer: {sl.Key} e {sl.Value}");
            }
        }
    }
}
