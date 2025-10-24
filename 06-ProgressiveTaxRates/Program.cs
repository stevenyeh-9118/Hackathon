namespace _06_ProgressiveTaxRates
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("請輸入您的年收入：");
            decimal income = decimal.Parse(Console.ReadLine());

            decimal tax = 0m;

            if (income <= 540000)
            {
                tax = income * 0.05m;
            }
            else if (income <= 1210000)
            {
                tax = (income - 540000) * 0.12m + 540000 * 0.05m;
            }
            else if (income <= 2420000)
            {
                tax = (income - 1210000) * 0.20m + (1210000 - 540000) * 0.12m + 540000 * 0.05m;
            }
            else if (income <= 4530000)
            {
                tax = (income - 2420000) * 0.30m + (2420000 - 1210000) * 0.20m + (1210000 - 540000) * 0.12m + 540000 * 0.05m;
            }
            else if (income <= 10310000)
            {
                tax = (income - 4530000) * 0.40m + (4530000 - 2420000) * 0.30m + (2420000 - 1210000) * 0.20m +
                      (1210000 - 540000) * 0.12m + 540000 * 0.05m;
            }
            else
            {
                tax = (income - 10310000) * 0.50m + (10310000 - 4530000) * 0.40m +
                      (4530000 - 2420000) * 0.30m + (2420000 - 1210000) * 0.20m +
                      (1210000 - 540000) * 0.12m + 540000 * 0.05m;
            }

            Console.WriteLine($"應繳稅額為：{tax:C}");
        }
    }
}
