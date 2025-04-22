namespace hwCSharpp
{
    public class Bank: Exception
    {
        public Bank(string message) : base(message) { }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Money num1 = 257;
            Money num2 = 600;


            try
            {
                CheckResult(num1 + num2, "+");
                CheckResult(num2 - num1, "-");
                CheckResult(num1 * 2, "*");
                CheckResult(num1 / 2, "/");
                CheckResult(num1++, "num1++");
                CheckResult(num2++, "num2++");
                CheckResult(num1--, "num1--");
                CheckResult(num2--, "num2--");
                Console.WriteLine($"==: {num1 == num2}");
                Console.WriteLine($"!=: {num1 != num2}");
                Console.WriteLine($">: {num1 > num2}");
                Console.WriteLine($"<: {num1 < num2}");
            }
            catch (Bank ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void CheckResult(Money result, string operation)
        {
            if (result.Sum < 0)
            {
                throw new Bank($"Нищий, итог операции {operation} меньше 0: {result.Sum}");
            }
            Console.WriteLine($"{operation}: {result.Sum}");
        }
    }
}
