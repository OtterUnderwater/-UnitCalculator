
namespace UnitTestingCalculator
{
	public class Calculator
	{
		double firstNum;
		double secondNum;
		public Calculator(double firstNum, double secondNum)
		{
			this.firstNum = firstNum;
			this.secondNum = secondNum;
		}

		// Cложение
		public double Addition() => firstNum + secondNum;
		// Вычитание
		public double Subtraction() => firstNum -  secondNum;
		// Умножение
		public double Multiplication() => firstNum * secondNum;
		// Деление
		public double Division()
		{
			if (secondNum == 0)
			{
				Console.WriteLine("Нельзя делить на 0");
				return 0;
			}
			else
			{
				return firstNum / secondNum;
			}
		}
		// Возведение в степень
		public double Exponentiation()
		{
			double result = firstNum;
			if (secondNum == 0)
			{
				result = 1;
			}
			else
			{
				for (int i = 1; i < secondNum; i++)
				{
					result *= firstNum;
				}
			}
			return result;
		}
	}
}
