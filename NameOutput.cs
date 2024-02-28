using System;

namespace NameOutput
{
	internal class NameOutput
	{
		static void Main(string[] args)
		{
			Console.Write("Введите ваше имя: ");
			string name = Console.ReadLine();

			Console.Write("Введите символ для прямоугольника: ");
			char symbol = Console.ReadKey(true).KeyChar;
			Console.WriteLine();

			string middleLine = symbol.ToString() + " " + name + " " + symbol.ToString();
			string borderLine = String.Empty;
			int widthRectangle = middleLine.Length;

			for (int i = 0; i < widthRectangle; ++i)
			{
				borderLine += symbol.ToString();
			}

			Console.WriteLine(borderLine);
			Console.WriteLine(middleLine);
			Console.WriteLine(borderLine);
		}
	}
}
