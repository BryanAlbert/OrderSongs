using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OrderSongs
{
	class Program
	{
		static void Main(string[] args)
		{
			string executionDirectory = AppDomain.CurrentDomain.BaseDirectory;
			executionDirectory = executionDirectory.Substring(0, executionDirectory.Length - 1);
			Console.WriteLine($"{executionDirectory}\n{Directory.GetCurrentDirectory()}");
			if (executionDirectory.ToLower() == Directory.GetCurrentDirectory().ToLower())
			{
				Console.WriteLine($"\nUsage: Change to export folder, then run this program from " +
					$"directory:\n{Directory.GetCurrentDirectory()}\n\nHit a key to quit.");
				Console.ReadKey();
			}
			else
			{
				Console.WriteLine("Hit a key to rename files, Q to quit");
				int prefix = 100;
				while (Console.ReadKey(true).Key != ConsoleKey.Q)
				{
					Console.WriteLine($"Renaming unordered files with prefix: {prefix}");
					foreach (var file in Directory.GetFiles("."))
					{
						if (!Regex.IsMatch(file, "[0-9]{3} "))
						{
							object oldName = file.Substring(2);
							string newName = $"{prefix} {oldName}";
							Console.WriteLine($"Renaming '{oldName}' to '{newName}'");
							Directory.Move(file, newName);
						}
					}

					Console.WriteLine("\nCopy next song's file then hit a key to rename files, Q to quit");
					prefix += 10;
				}
			}
		}
	}
}
