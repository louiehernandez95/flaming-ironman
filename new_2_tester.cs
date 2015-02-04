using System;
class MainClass
{
	public static void UserWeightInputPrompt()
	{	
		int WeightSum, ExamsWeight, LabsWeight, HomeworkWeight, ProjectWeight, ParticipationWeight;
        string ExamsWeightString, LabsWeightString, HomeworkWeightString, ProjectWeightString, ParticipationWeightString;
         
         int WeightTest = 0;
         while (WeightTest != 100)
         {
            Console.WriteLine ("Enter Exams Weight: ");
            ExamsWeightString = Console.ReadLine ();
            ExamsWeight = int.Parse (ExamsWeightString);

            Console.WriteLine ("Enter Labs Weight: ");
            LabsWeightString = Console.ReadLine ();
            LabsWeight = int.Parse (LabsWeightString);

            Console.WriteLine ("Enter Homework Weight: ");
            HomeworkWeightString = Console.ReadLine ();
            HomeworkWeight = int.Parse (HomeworkWeightString);

            Console.WriteLine ("Enter Projects Weight: ");
            ProjectWeightString = Console.ReadLine ();
            ProjectWeight = int.Parse (ProjectWeightString);

            Console.WriteLine ("Enter Participation Weight: ");
            ParticipationWeightString = Console.ReadLine ();
            ParticipationWeight = int.Parse (ParticipationWeightString);

            WeightSum = ExamsWeight + LabsWeight + HomeworkWeight + ProjectWeight + ParticipationWeight;
            WeightTest = WeightSum;

         if (WeightTest == 100) {
            Console.WriteLine ("Congratulations! Weights add to 100% ");
         } else if (WeightTest != 100) {
            Console.WriteLine ("Grades add to " + WeightTest + " not 100. Please try again.");
         } else
            return;
         }
	}
}