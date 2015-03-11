using System;
using System.IO;

namespace IntroCS
{
	class GradeFile
	{

		public static void Main(string[]args)
		{
			{
				string sample = "sample.txt";
				string output = "output.txt";
				Console.WriteLine("Directory of {0}: {1}",
					sample, FIO.GetLocation(sample));
				Console.WriteLine("Path to {0}: {1}",
					sample, FIO.GetPath(sample));
				StreamReader reader1 = FIO.OpenReader(sample);
				if (reader1 != null) {
					Console.Write(reader1.ReadToEnd());
					Console.WriteLine("First reader test passed.");
					reader1.Close();
				}
				StreamReader reader2 = FIO.OpenReader(FIO.GetLocation(sample),
					sample);
				if (reader2 != null) {
					Console.WriteLine("Second reader test passed.");
					reader2.Close();
				}
				StreamWriter writer1 = FIO.OpenWriter(FIO.GetLocation(sample),
					output);
				writer1.WriteLine("File in the same directory as {0}.", sample);
				writer1.Close();
				Console.WriteLine("Writer test passed; file written at \n {0}",
					FIO.GetPath(output));
			}
		}
		static int codeIndex(string code, string[] categories)
		{
			for (int i = 0; i < categories.Length; i++) {
				if (categories[i].Trim().StartsWith(code)) {
					return i;
				}
			}
			return -1;
		}
		static string[] getStringArray(string input)
		{
			string[] code = input.Split(',');
			return code;
		}
		static int[] getIntArray(string input)
		{
			string[] code = input.Split(',');
			int[] intparts = new int[code.Length];
			for (int i=0; i < code.Length; i++)
				intparts[i] = int.Parse(code[i]);
			return intparts;
		}
		static string[] getClassCategories(string categoryFileName)
		{
			var reader = new StreamReader(categoryFileName);
			string categories = reader.ReadLine();
			string[] catnames = getStringArray (categories);
			for (int i = 0; i < catnames.Length; i++)
			{
				Console.Write ("{0} {1}", i, catnames [i]);
				string firstLetters = catnames[i];
				string first_letter = firstLetters.Substring(0,1);
				Console.Write("{0} {1}", i, first_letter);
			}
			return catnames;
		}
		static int[] weightValues(string categoryFileName)
		{
			int targetLine = 2;
			int counter = 1;
			int[] weight_values = new int[0];
			var reader = new StreamReader (categoryFileName);
			while (!reader.EndOfStream) {
				string weights = reader.ReadLine();
				if (counter == targetLine) {
					weight_values = getIntArray(weights);
				}
				counter++;
			}
			for (int i = 0; i < weight_values.Length; i++)
			{
				Console.WriteLine("{0}{1}", i,
					weight_values[i]);
			}

			return weight_values;
		}
		static int[] numberscat(string categoryFileName)
		{
			int targetLine = 3;
			int counter = 1;
			int[] item_values = new int[0];
			var reader = new StreamReader(categoryFileName);
			while (!reader.EndOfStream)
			{
				string items = reader.ReadLine();
				if (counter == targetLine)
				{
					item_values = getIntArray(items);
				}
				counter++;
			}
			for (int i = 0; i < item_values.Length; i++)
			{

				Console.WriteLine (" {0}{1}", i,
					item_values [i]);
			}
			return item_values;
		}
		static string[] getRoster(string studentFileName, int targetLine)
		{
			int counter = 1;
			string[] next_Student = new string [0];
			var reader = FIO.OpenReader(studentFileName);
			while (!reader.EndOfStream)
			{
				string item = reader.ReadLine();
				if (counter == targetLine)
				{
					next_Student = getStringArray(item);
				}
				counter++;
			}
			for (int i=0; i < next_Student.Length; i++)
			{
				Console.Write ("{0}",next_Student[i]);
			}
			Console.ReadLine ();
			return next_Student;
		}
	}
}
