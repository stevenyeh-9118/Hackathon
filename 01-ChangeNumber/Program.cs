namespace _01_ChangeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一個大於90的數:");
            int max = int.Parse(Console.ReadLine());
            if (max < 90)
            {
                Console.WriteLine("輸入必須至少大於或等於 90。");
            }

            for (int i = 1; i <= max; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("Dann");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Build");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("School");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
