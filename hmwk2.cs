using System;

namespace IntroCS
{
  class MainClass
  {
    public static void Main (string[] args)
    {
      Console.WriteLine("This Calculator will help you determine a grade in a " + "given class.\n");
      getWeights();
      getAverages();
      double finalGrade = GiveFinalGrade(double examAverage, double examWeight, double projectAverage, double projectWeight, double labAverage, double labWeight, double homeworkAverage, double homeworkWeight, double participationAverage, double participationWeight);
      GradeAssignments(double finalGrade);
    }

    //prompts user for weights, tests if adds to 100, loops back if test fails
    public static void getWeights()
    {
      Console.WriteLine("Begin by entering individual category weights, they " + "must add to 100%\n");
      double weightSum = 0;
      do{
        double examWeight = FindWeight("exam");
        double projectWeight = FindWeight("project");
        double labWeight = FindWeight("lab");
        double homeworkWeight = FindWeight("homework");
        double participationWeight = FindWeight("participation point");
        weightSum = (examWeight + projectWeight + labWeight + homeworkWeight + participationWeight);
        if (weightSum == 100) {
          Console.WriteLine ("Congratulations! Weights add to 100%\n");
        } else{
            Console.WriteLine("Sorry weights did not add to 100%, please try " + "again.\n");
          }
      }while(weightSum != 100);
    }

    //prompts user for weights of each category
    public static double FindWeight(string weightPrompt)
    {
      double weight = UI.PromptDouble("Please enter the weight of " + weightPrompt + "(s): ");
      return weight;
    }

    //gets and assigns average grades of each category
    public static void getAverages()
    {
      double examAverage = FindAverage("exam");
      double projectAverage = FindAverage("project");
      double labAverage = FindAverage("lab");
      double homeworkAverage = FindAverage("homework assignment");
      double participationAverage = FindAverage ("participation point");
    }

    //prompts for grade and averages the scores for passed in categories
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

    //computes final overall grade
    public static double GiveFinalGrade(double examAverage, double examWeight, double projectAverage, double projectWeight, double labAverage, double labWeight, double homeworkAverage, double homeworkWeight, double participationAverage, double participationWeight)
    {
      double finalGrade = (examAverage * examWeight + projectAverage * projectWeight + labAverage * labWeight + homeworkAverage * homeworkWeight + participationAverage * participationWeight)/100;
      return finalGrade;
    }

    //calcs and assigns grade
    public static string GradeAssignments(double grade)
    {
      string LetterGradeMsg, GradeLetter;
      if (grade == 100){
      GradeLetter = ", an A+ ";
      }
      else if (grade >= 93) {
        GradeLetter = ", an A ";
      }
      else if (grade >= 90) {
        GradeLetter = ", an A- ";
      }
      else if (grade >= 87) {
        GradeLetter = ", a B+ ";
      }
      else if (grade >= 83) {
        GradeLetter = ", a B ";
      }
      else if (grade >= 80) {
        GradeLetter = ", a B- ";
      }
      else if (grade >= 77) {
        GradeLetter = ", a C+ ";
      }
      else if (grade >= 73) {
        GradeLetter = ", a C ";
      }
      else if (grade >= 70) {
        GradeLetter = ", a C- ";
      }
      else if (grade >= 67) {
        GradeLetter = ", a D+ ";
      }
      else if (grade >= 63) {
        GradeLetter = ", a D ";
      }
      else if (grade >= 60) {
        GradeLetter = ", a D- ";
      }
      else {
        GradeLetter = ". It is so low that you are unlikely to pass ";
      }
      LetterGradeMsg = GradeLetter;
			grade = Math.Round(grade, 2);	//CAM couldn't get the technique from the book to work, found this other technique
			Console.WriteLine("Your grade is " + grade + LetterGradeMsg);
    }
  }
}
