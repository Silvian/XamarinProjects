using System;
using Microsoft;
//using MSScriptControl;

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

//		public void Evaluate()
//		{
//			MSScriptControl.ScriptControl sc = new MSScriptControl.ScriptControl();
//			sc.Language = "VBScript";
//			string expression = "1 + 2 * 7";
//			object result = sc.Eval(expression);            
//			MessageBox.Show(result.ToString());
//
//		}

	}
}

