﻿using System;

   class MainClass 
   {
      static void Main () 
      {

         int ExamsWeight, LabsWeight, HomeworkWeight, ProjectWeight, ParticipationWeight;
         double ExamsGrade, LabsGrade, HomeworkGrade, ProjectGrade, ParticipationGrade;
         string ExamsWeightString, LabsWeightString, HomeworkWeightString, ProjectWeightString, ParticipationWeightString;
         string ExamsGradeString, LabsGradeString, HomeworkGradeString, ProjectGradeString, ParticipationGradeString;
         int sum = ParticipationGradeWeight + ProjectGradeWeight + HomeworkGradeWeight + LabsGradeWeight + ExamsGradeWeight



            Console.WriteLine ("This Calculator will help you determine a grade in a given class. Remember to have the weights add to 100%");


         Console.WriteLine ("Enter Exams Weight: ");
         ExamsWeightString = Console.ReadLine();
         ExamsWeight = int.Parse(ExamsWeightString);
         Console.WriteLine ("Enter Labs Weight: ");
         LabsWeightString = Console.ReadLine();
         LabsWeight = int.Parse(LabsWeightString);
         Console.WriteLine ("Enter Homework Weight: ");
         HomeworkWeightString = Console.ReadLine();
         HomeworkWeight = int.Parse(HomeworkWeightString);
         Console.WriteLine ("Enter Projects Weight: ");
         ProjectWeightString = Console.ReadLine();
         ProjectWeight = int.Parse(ProjectsWeightString);
         Console.WriteLine ("Enter Participation Weight: ");
         ParticipationWeightString = Console.ReadLine();
         ParticipationWeight = int.Parse(ParticipationWeightString);

         // int GradeWeightChecker *STILL WORKING ON THIS* packages the grade weight check

         if (ParticipationWeight + ProjectWeight + HomeworkWeight + LabsWeight + ExamsWeight == "100") {
            Console.WriteLine ("Congratulations! Weights add to 100% ");
         }

         else  {
            Console.WriteLine ("Grades add to " + sum + " not 100%"); //fix typo
            return; // added return to stop program if true *STILL NEED TO FINALIZE*
         }



         // i still need to review this section
         Console.WriteLine ( "Enter Exams Grade: ");
         ExamsGradeString = Console.ReadLine();
         ExamsGrade = double.Parse(ExamsGradeString);
         Console.WriteLine ( "Enter Labs Grade: ");
         LabsGradeString = Console.ReadLine();
         LabsGrade = double.Parse(LabsGradeString);
         Console.WriteLine ( "Enter Homework Grade: ");
         HomeworkGradeString = Console.ReadLine();
         HomeworkGrade = double.Parse(HomeworkGradeString);
         Console.WriteLine ( "Enter Projects Grade: ");
         ProjectGradeString = Console.ReadLine();
         ProjectGrade = double.Parse(ProjectsGradeString);
         Console.WriteLine ( "Enter Participation Grade: ");
         ParticipationGradeString = Console.ReadLine();
         ParticipationGrade = double.Parse(ParticipationGradeString);



         // this double looks fine
         double grade = (ExamsWeight * ExamsGrade + HomeworkWeight * HomeworkGrade + LabsWeight * LabsGrade + ProjectWeight * ProjectGrade
            + ParticipationWeight * ParticipationGrade / 100.00); // added missed parenthesis added one more zero 


         // still working on the if statements logic
         //changed "Less than" signs to "Less than or equal to"
         string LetterGradeMsg, GradeLetter;

         if (grade == 100){
            GradeLetter = ("an A+ ");
         }
         else if (grade >= 93) {
            GradeLetter = ("an A ");
         }  
         else if (grade >= 90) {
            GradeLetter = ("an A- ");
         }
         else if (grade >= 87) {
            GradeLetter = ("a B+ ");
         }
         else if (grade >= 83) {
            (GradeLetter = ("a B ");
         }
         else if (grade >= 80) {
            (GradeLetter = ("a B- ");
         }
         else if (grade >= 77) {
            (GradeLetter = ("a C+ ");
         }
         else if (grade >= 73) {
            (GradeLetter = ("a C ");
         }
         else if (grade >= 70) {
            (GradeLetter = ("a C- ");
         }
         else if (grade >= 67) {
            (GradeLetter = ("a D+ ");
         }
         else if (grade >= 63) {
            (GradeLetter = ("a D ");
         }              
         else if (grade >= 60) {
            (GradeLetter = ("a D- ");
         }
         else if (grade < 60){
            (GradeLetter = ("so low that you are unlikely to pass ");
         }
                 
   
   LetterGradeMsg = ConsoleReadLine();
   Console.WriteLine("Your grade is " + LetterGradeMsg);
                                                               }
                                                               }
                                                               }