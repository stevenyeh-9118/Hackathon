namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一句英文：");
            string input = Console.ReadLine().ToLower();

            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            Console.WriteLine();

            foreach (var pair in wordCount)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
        }
    }
}
