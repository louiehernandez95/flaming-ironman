using System;

namespace test.cs
{
public class LetterGrade
{ 
    int grade = 94;
    static string GradeLetterMsg()
    {  
		public static void Main()
		{
			if (grade == 100){
				Console.WriteLine (GradeLetter("an A+ "));
			}
			else if (grade >= 93) {
				Console.WriteLine (GradeLetter("an A "));
			}  
			else if (grade >= 90) {
				Console.WriteLine (GradeLetter("an A- "));
			}
			else if (grade >= 87) {
			Console.WriteLine (GradeLetter("a B+ "));
			}
			else if (grade >= 83) {
            Console.WriteLine (GradeLetter("a B "));
			}
			else if (grade >= 80) {
            Console.WriteLine (GradeLetter("a B- "));
			}
			else if (grade >= 77) {
            Console.WriteLine (GradeLetter("a C+ "));
			}
			else if (grade >= 73) {
            Console.WriteLine (GradeLetter("a C "));
			}
			else if (grade >= 70) {
            Console.WriteLine (GradeLetter("a C- "));
			}
			else if (grade >= 67) {
            Console.WriteLine (GradeLetter("a D+ "));
			}
			else if (grade >= 63) {
            Console.WriteLine (GradeLetter("a D "));
			}              
			else if (grade >= 60) {
			Console.WriteLine (GradeLetter("a D- "));
			}
			else if (grade < 60){
			Console.WriteLine (GradeLetter("so low that you are unlikely to pass "));
			}
		}
		LetterGrade = ConsoleReadLine();
        Console.WriteLine("Your grade is " + LetterGrade);
   }
}