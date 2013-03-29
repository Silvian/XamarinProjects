using System;

namespace HelloMac
{
	public class Calculator
	{
		double result;
		double total;
		double input;

		public Calculator ()
		{
			result = 0;
			total = 0;
			input = 0;
		}

		public Calculator(double input)
		{
			result = 0;
			total = 0;
			this.input = input;
		}

		public void setInput(double input)
		{
			this.input = input;
		}

		public double getResult()
		{
			return result;
		}

		public void Add()
		{

		}

		public void Substract()
		{

		}

		public void Multiply() 
		{

		}

		public void Divide()
		{

		}

	}
}

