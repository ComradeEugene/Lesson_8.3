using System;
using static System.Console;
using System.Collections.Generic;

namespace Lesson_8._3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ConsoleKeyInfo cki;
			HashSet<int> digits = new HashSet<int>();

			do
			{
				Clear();
				WriteLine("Введите число");
				int temp = int.Parse(ReadLine());
				if (digits.Contains(temp))
				{
					WriteLine("Такой число уже существует");
				}
				else
				{ 
					digits.Add(temp);
					WriteLine("Число добавлено");
				}
				WriteLine("ESC - выход ENTER - продолжить");
				cki = ReadKey();
			} while (cki.Key != ConsoleKey.Escape);
		}
	}
}
