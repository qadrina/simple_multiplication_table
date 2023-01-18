using System;
					
public class Program
{
	public static void Main()
	{
		MultiTable(2);
	}
	
	public static void MultiTable(int x) 
	{
		for (int i = 0; i <= 10; i++) 
		{
			Console.WriteLine("{0} x {1} = {2}", x, i, x*i);
		}
	}
	
}
