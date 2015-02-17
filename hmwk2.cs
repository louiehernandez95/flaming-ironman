using System;

namespace IntroCS
{
   class MainClass
   {
      public static void Main (string[] args)
      {
        Console.WriteLine("This Calculator will help you determine a grade in a given class.");
        getAverages();
      }


      public static void getAverages()
      {
        int examAverage = FindAverage("exam");
        int projectAverage = FindAverage("project");
        int labAverage = FindAverage("lab");
        int homeworkAverage = FindAverage("homework assignment");
        int participationAverage = FindAverage ("participation point");

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
