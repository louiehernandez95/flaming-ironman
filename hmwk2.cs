using System;

namespace IntroCS
{
   class MainClass
   {
      public static void Main (string[] args)
      {
        Console.WriteLine("This Calculator will help you determine a grade in a given class.\n");
        getWeights();
        getAverages();
      }

      public static void getWeights()
      {
        Console.WriteLine("Begin by entering individual category weights, they must add to 100%\n");
        double examWeight = FindWeight("exam");
        double projectWeight = FindWeight("project");
        double labWeight = FindWeight("lab");
        double homeworkWeight = FindWeight("homework");
        double participationWeight = FindWeight("participation point");
        double weightSum = (examWeight + projectWeight + labWeight + homeworkWeight + participationWeight);

        if (weightSum == 100) {
           Console.WriteLine ("Congratulations! Weights add to 100%\n");
        } else {Console.WriteLine("Sorry weights did not add to 100%, please try again.\n");
            return;
          }
      }
      public static double FindWeight(string weightPrompt)
      {
        double weight = UI.PromptDouble("Please enter the weight of " + weightPrompt + "(s): ");
        return weight;
      }
      public static void getAverages()
      {
        double examAverage = FindAverage("exam");
        double projectAverage = FindAverage("project");
        double labAverage = FindAverage("lab");
        double homeworkAverage = FindAverage("homework assignment");
        double participationAverage = FindAverage ("participation point");

      }
      public static double FindAverage(string gradePrompt)
      {
        double numberOfGrades = UI.PromptDouble("Please enter the number of " + gradePrompt +  "(s) to grade: ");
        double i = 1;
        double totalScore = 0;
         do{
          double score = UI.PromptDouble("Please enter the grade of assignment " + i + ": ");
          i++;
          totalScore += score;
        } while (i <= numberOfGrades);
         return totalScore / numberOfGrades;
      }
   }
}
