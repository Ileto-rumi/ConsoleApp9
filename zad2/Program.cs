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
                string dumi = word.ToLower(); // Преобразуваме всяка дума в малки букви за да избегнем дублиране на същите думи с различни регистри

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
                Console.WriteLine($"Дума: '{duma.Key}', Честота: {duma.Value}");
            }
        }
    }
}
