using System;
using System.IO;
using System.Collections.Generic;


namespace IntroCS
{
	class GradeFiles
	{
		/// Process grade files based on a class abbreviation
		/// on the command line, or provided interactively.
		public static void Main(string[] args)
		{
			string categoryFileName = "categories_comp170.txt";
			var reader1 = FIO.OpenReader(categoryFileName);
			while (!File.Exists(categoryFileName)) 
			{
				Console.WriteLine ("File not found");
				Console.Write("Please enter the course abbreviation: ");
				string courseAbbreviation = Console.ReadLine ();
				categoryFileName = "categories_" +  courseAbbreviation + ".txt";
				reader1 = FIO.OpenReader(categoryFileName);
			}
			while(!reader1.EndOfStream)
			{
				reader1.ReadToEnd();
			}
			reader1.Close();
			string studentFileName = "students_comp170.txt";
			var reader2 = FIO.OpenReader(categoryFileName);
			while(!reader2.EndOfStream)
			{
				reader2.ReadToEnd();
			}
			reader2.Close();

			List<string[]> student_list = new List<string[]>();



		
		}


		// codeIndex chunk
		/// Take the first letter code for a catagory, and
		/// return the index of that category in categories.
		static int codeIndex(string code, string[] categories)
		{
			for (int i = 0; i < categories.Length; i++)
			{
				if (categories[i].Trim().StartsWith(code))
				{
					return i;
				}
			}
			return -1; //required by compiler: shouldn't reach
		}
	} // end codeIndex chunk
}
