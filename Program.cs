using System;
using System.Collections.Generic;
using System.Linq;
public class Contador
{
	public static void Main()
	{
		int Contador = 0;

		Console.Write("Hasta que numero le gustaria contar? ");
		Contador = Int32.Parse(Console.ReadLine());


		int Bucle(int a)
		{
			for (int i = 1; i <= Contador; i++)
			{
				Console.WriteLine(i);
			}
			return a;
		}


		Func<int, int> b = (a) =>
		{
			Bucle(Contador);
			return a;
		};

		int Total = b(Contador);
		Console.ReadKey();

	}
}
