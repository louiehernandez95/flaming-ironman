using System;
class MainClass
{
	public void UserWeightInputPrompt()
	{	

		int ExamsWeight, LabsWeight, HomeworkWeight, ProjectWeight, ParticipationWeight;
		string ExamsWeightString, LabsWeightString, HomeworkWeightString, ProjectWeightString, ParticipationWeightString;

		int WeightSum;
		do
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
		} while (WeightSum != 100);

		if (WeightSum == 100) {
			Console.WriteLine ("Congratulations! Weights add to 100% ");
		}
		else {
			Console.WriteLine ("Grades add to " + WeightSum + " not 100%. Please try again.");
			return;
		}
	}
}