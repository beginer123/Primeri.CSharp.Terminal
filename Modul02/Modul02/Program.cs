using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");

			//Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;

			//Събиране на променливи
			a = 5;
			b = 10;
			sum = a + b;

			//Писане в конзола
			Console.Write(a);
			Console.Write(" + ");
			Console.Write(b);
			Console.Write(" = ");

			Console.WriteLine(sum);

			//Допълнителни оператори
			Console.WriteLine("\n Използване на + =");
			a += b;
			Console.WriteLine(a);

			Console.WriteLine("\n Използване на - =");
			a -= b;
			Console.WriteLine(a);


			Console.WriteLine("\n Използване на + +");
			a ++;
			Console.WriteLine(a);

			Console.WriteLine("\n Използване на *");
			a *= b;
			Console.WriteLine(a);

			Console.WriteLine("Staqndartno delene: " + (7 / 4));
			Console.WriteLine("Ostatyk delene: " + (7 % 4));

			                  



		}
	}
}
