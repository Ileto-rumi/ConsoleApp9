namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> chestota = new Dictionary<string, int>();
            string vhod = Console.ReadLine();
            string[] words = vhod.Split(new[] { ' ', '.', ',', ';', '!', '?', '-', ':', '(', ')', '[', ']', '{', '}', '"' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                string dumi = word.ToLower(); 

                if (chestota.ContainsKey(dumi))
                {
                    chestota[dumi]++;
                }
                else
                {
                    chestota.Add(dumi, 1);
                }
            }
            Console.WriteLine("Chestota:");
            foreach (var duma in chestota)
            {
                Console.WriteLine($"Dumata '{duma.Key}' e izpolzvana {duma.Value} puti.");
            }
        }
    }
}
