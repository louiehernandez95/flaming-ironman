using System;
using IntroCS;

namespace gradecalc
{
   class MainClass
   {
      public static void Main (string[] args)
      {
        //int categoryNumber = UI.PromptInt("Please enter the number of grades in the category exam: ");

        int examAverage = FindAverage ("Please enter the number of grades in the exam category: ");
      }

      public static int FindAverage(string userprompt)
      {
        Console.WriteLine(userprompt);
        int numberOfGrades = int.Parse(Console.ReadLine());

        int i = 1;
        int totalScore = 0;
        do{
          int score = UI.PromptInt("Please enter the grade of assignment " + i + ": ");
          i++;
          totalScore += score;
        } while (i < numberOfGrades);
        return totalScore / numberofGrades;
      }

      /*
      {
         Console.WriteLine ("Hello World!");
         string hello = UI.PromptLine("Enter hello: ");
         Console.WriteLine(hello);
      }
      */
   }
}
