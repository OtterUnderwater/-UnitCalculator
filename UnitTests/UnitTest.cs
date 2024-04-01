using UnitTestingCalculator;

namespace UnitTests
{
	[TestClass]
	public class UnitTest
	{ 
		/// <summary>
		/// Положительное тестирование метода Cложения
		/// </summary>
		[TestMethod]
		public void Addition_15plus2_Return17()
		{
			double firstNum = 15;
			double secondNum = 2.1;
			double except = 17.1;

			Calculator example = new Calculator(firstNum, secondNum);
			double result = example.Addition();

			Assert.AreEqual(except, result);
		}

		/// <summary>
		/// Негативное тестирование метода Cложения
		/// </summary>
		[TestMethod]
		public void Addition_15plus2_Notreturn10()
		{
			double firstNum = 15;
			double secondNum = 2.1;
			double except = 10;

			Calculator example = new Calculator(firstNum, secondNum);
			double result = example.Addition();

			Assert.AreNotEqual(except, result);
		}

		/// <summary>
		/// Положительное тестирование метода Вычитания
		/// </summary>
		[TestMethod]
		public void Subtraction_15minus5_Return10()
		{
			double firstNum = 15;
			double secondNum = 5;
			double except = 10;

			Calculator example = new Calculator(firstNum, secondNum);
			double result = example.Subtraction();

			Assert.AreEqual(except, result);
		}

		/// <summary>
		/// Негативное тестирование метода Вычитания
		/// </summary>
		[TestMethod]
		public void Subtraction_15minus5_Notreturn20()
		{
			double firstNum = 15;
			double secondNum = 5;
			double except = 20;

			Calculator example = new Calculator(firstNum, secondNum);
			double result = example.Subtraction();

			Assert.AreNotEqual(except, result);
		}

		/// <summary>
		/// Положительное тестирование метода Умножения
		/// </summary>
		[TestMethod]
		public void Multiplication_Multiply20And2_Return40()
		{
			double firstNum = 20;
			double secondNum = 2;
			double except = 40;

			Calculator example = new Calculator(firstNum, secondNum);
			double result = example.Multiplication();

			Assert.AreEqual(except, result);
		}

		/// <summary>
		/// Негативное тестирование метода Умножения
		/// </summary>
		[TestMethod]
		public void Multiplication_MultiplyMinus10And2_Notreturn20()
		{
			double firstNum = -10;
			double secondNum = 2;
			double except = 20;

			Calculator example = new Calculator(firstNum, secondNum);
			double result = example.Multiplication();

			Assert.AreNotEqual(except, result);
		}

		/// <summary>
		/// Положительное тестирование метода Деления
		/// </summary>
		[TestMethod]
		public void Division_Divide14And2_Return7()
		{
			double firstNum = 14;
			double secondNum = 2;
			double except = 7;

			Calculator example = new Calculator(firstNum, secondNum);
			double result = example.Division();

			Assert.AreEqual(except, result);
		}

		/// <summary>
		/// Негативное тестирование метода Деления
		/// </summary>
		[TestMethod]
		public void Division_Divide14And0_Notreturn14()
		{
			double firstNum = 14;
			double secondNum = 0;
			double except = 14;

			Calculator example = new Calculator(firstNum, secondNum);
			double result = example.Division();

			Assert.AreNotEqual(except, result);
		}

		/// <summary>
		/// Положительное тестирование метода Степени
		/// </summary>
		[TestMethod]
		public void Exponentiation_5power3_Return125()
		{
			double firstNum = 5;
			double secondNum = 3;
			double except = 125;

			Calculator example = new Calculator(firstNum, secondNum);
			double result = example.Exponentiation();

			Assert.AreEqual(except, result);
		}

		/// <summary>
		/// Негативное тестирование метода Степени
		/// </summary>
		[TestMethod]
		public void Exponentiation_10power0_Notreturn10()
		{
			double firstNum = 10;
			double secondNum = 0;
			double except = 10;

			Calculator example = new Calculator(firstNum, secondNum);
			double result = example.Exponentiation();

			Assert.AreNotEqual(except, result);
		}
	}
}