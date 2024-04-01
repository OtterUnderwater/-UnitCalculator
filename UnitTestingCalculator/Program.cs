
namespace UnitTestingCalculator
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Введите первое число:");
			double firstNum = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите второе число:");
			double secondNum = Convert.ToDouble(Console.ReadLine());
			Calculator example = new Calculator(firstNum, secondNum);	
			Console.WriteLine($"Сумма: {example.Addition()}");
			Console.WriteLine($"Вычитание: {example.Subtraction()}");
			Console.WriteLine($"Умножение: {example.Multiplication()}");
			Console.WriteLine($"Деление: {example.Division()}");
			Console.WriteLine($"Возведение в степень: {example.Exponentiation()}");
		}
	}
}
