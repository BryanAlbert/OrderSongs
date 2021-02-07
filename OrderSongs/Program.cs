using System;
using System.IO;
using System.Text.RegularExpressions;

namespace OrderSongs
{
	class Program
	{
		static void Main(string[] args)
		{
			string executionDirectory = AppDomain.CurrentDomain.BaseDirectory;
			executionDirectory = executionDirectory.Substring(0, executionDirectory.Length - 1);

#if DEBUG
			Console.WriteLine($"{executionDirectory}\n{Directory.GetCurrentDirectory()}\n" +
				$"File and folder count: {Directory.GetFiles(".", "*", SearchOption.AllDirectories).Length}");
#endif

			if (executionDirectory.ToLower() == Directory.GetCurrentDirectory().ToLower())
			{
				if (Directory.GetFiles(".", "*", SearchOption.AllDirectories).Length > 1)
				{
					Console.WriteLine("\nUsage: Copy this program to the empty export folder and launch it");
					Console.WriteLine("from there, then copy the first song's files, hit a key, and repeat.");
					Console.WriteLine("\nAlternatively, in PowerShell or Command Prompt, cd to the export");
					Console.WriteLine("folder, run this program from an absolute path (or relative path),");
					Console.WriteLine("copy the first song's files, hit a key, and repeat. Program's path:");
					Console.WriteLine($"{ Directory.GetCurrentDirectory()}\\OrderSongs.exe");
					Console.WriteLine("\nHit a key to quit...");
					Console.ReadKey();
					return;
				}
			}

			Console.WriteLine("Copy first song's files then hit a key to rename them, or Q to quit");
			int prefix = 100;
			while (Console.ReadKey(true).Key != ConsoleKey.Q)
			{
				Console.WriteLine($"Renaming unordered files with prefix: {prefix}");
				foreach (var file in Directory.GetFiles("."))
				{
					if (file == @".\OrderSongs.exe")
						continue;

					if (!Regex.IsMatch(file, "[0-9]{3} "))
					{
						object oldName = file.Substring(2);
						string newName = $"{prefix} {oldName}";
						Console.WriteLine($"Renaming '{oldName}' to '{newName}'");
						Directory.Move(file, newName);
					}
				}

				Console.WriteLine("\nCopy next song's file then hit a key to rename them, or Q when finished...");
				prefix += 10;
			}
		}
	}
}
