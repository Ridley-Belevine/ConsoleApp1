using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
	static void Main(string[] args)
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Я сойду и намечу");

		Console.WriteLine();

		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine("Я сойду и намечу");
		Console.WriteLine("Мой вечерний путь.");
		Console.WriteLine("Выходи навстречу —");
		Console.WriteLine("В высоте отдохнуть.");
		Console.WriteLine("Полюби мои зори —");
		Console.WriteLine("Знак моей любви.");
		Console.WriteLine("И в свободное море");
		Console.WriteLine("Навсегда плыви.");

		Console.ResetColor();

		Console.ReadKey();
	}
}
