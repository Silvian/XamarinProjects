using System;

namespace HelloMac
{
	public class Calculate
	{
		Calculator calculator;
		String input;
		String result;
		double doubleInput;

		public Calculate ()
		{
			calculator = new Calculator();
		}

		public Calculate (String input)
		{
			calculator = new Calculator();
		}

		public String calculate(String input)
		{
			return result;
		}

		private double parseStringInput(String input)
		{
			char [] charInput = input.ToCharArray();
			double num1 = 0;
			double num2 = 0;

			for(int i = 0; i < input.Length; i++)
			{
				if(charInput[i].Equals("[0-9]"))
				{
					num1 = (double) charInput[i];
				}
			}

			if(input.Contains("+"))
			{
				calculator.Add();
			}
		
			if(input.Contains("-"))
			{
				calculator.Substract();
			}

			if(input.Contains("*"))
			{
				calculator.Multiply();
			}

			if(input.Contains("/"))
			{
				calculator.Divide();
			}
			

			return doubleInput;
		}

		public void setInput(String input)
		{
			this.input = input;
		}

		public String getResult()
		{
			return result;
		}

	}
}

