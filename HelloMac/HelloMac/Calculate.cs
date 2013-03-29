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
			for(int i = 0; i < input.Length; i++)
			{
				if(input.Contains("+"))
				{

				}
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

