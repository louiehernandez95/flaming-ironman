using System;
using IntroCS;

namespace gradecalc
{
   class MainClass
   {
      public static void Main (string[] args)
      {
        // int categoryNumber = UI.PromptInt("Please enter the total number of categories: ");
        int examAverage = FindAverage("exam");
        int projectAverage = FindAverage("project");
        int labAverage = FindAverage("lab");
        int homeworkAverage = FindAverage("homework assignment");
        int participationAverage = FindAverage ("participation point");
        //* continute here
      }



      public static int FindAverage(string gradePrompt)
      {
        int numberOfGrades = UI.PromptInt("Please enter the number of " + gradePrompt +  "(s) to grade: ");
        int i = 1;
        int totalScore = 0;
         do{
          int score = UI.PromptInt("Please enter the grade of assignment " + i + ": ");
          i++;
          totalScore += score;
        } while (i <= numberOfGrades);
         return totalScore / numberOfGrades;
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
