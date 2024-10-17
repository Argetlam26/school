using System;

public class Program
{
	public static double CircuitOfTriangle(double a, double b, double c){
		try{
		if (a+b<=c||a+c<=b||b+c<=a)
		{
			throw new ArgumentException ("nekde mas chybu kamo");
		}
		else{
		return a+b+c;
		}
		}
		catch(ArgumentException ae){
			Console.WriteLine(ae.Message);
			return 0;
		}
	}
	
	public static void Main()
	{
		double a = 1.0;
		double b = 1.0;
		double c = 5.0;
		Console.WriteLine(CircuitOfTriangle(a, b, c));
	}
}
