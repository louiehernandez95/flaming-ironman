		//added a section that properly loops if user fails to enter correct weights
		public static void UserGradeInputPrompt()
		{	
			int ExamsWeight, LabsWeight, HomeworkWeight, ProjectWeight, ParticipationWeight;
			string ExamsWeightString, LabsWeightString, HomeworkWeightString, ProjectWeightString, ParticipationWeightString;
			
			double GradeTotal;
			int WeightSum; 
			
			//finalgrade while loop done
			double FinalGrade = 0;
			while (FinalGrade >100 , <0)
			{
				string LetterGradeMsg, GradeLetter;
				string GradeNotInRangeString = "Oops, your grade is not between 0 and 100%. Try your inputs again."
				
				Console.WriteLine ("Enter Exams Grade: ");
				ExamsGradeString = Console.ReadLine();
				ExamsGrade = double.Parse(ExamsGradeString);
				
				Console.WriteLine ("Enter Labs Grade: ");
				LabsGradeString = Console.ReadLine();
				LabsGrade = double.Parse(LabsGradeString);
				
				Console.WriteLine ("Enter Homework Grade: ");
				HomeworkGradeString = Console.ReadLine();
				HomeworkGrade = double.Parse(HomeworkGradeString);
				
				Console.WriteLine ("Enter Projects Grade: ");
				ProjectGradeString = Console.ReadLine();
				ProjectGrade = double.Parse(ProjectGradeString);
				
				Console.WriteLine ("Enter Participation Grade: ");
				ParticipationGradeString = Console.ReadLine();
				ParticipationGrade = double.Parse(ParticipationGradeString);
				

				GradeTotal = ((ExamsWeight * ExamsGrade + HomeworkWeight * HomeworkGrade + LabsWeight * LabsGrade + ProjectWeight * ProjectGrade + ParticipationWeight * ParticipationGrade) / 100.00);
				FinalGrade = GradeTotal;
			}
			if (FinalGrade == 100) {
				Console.WriteLine ("Congratulations! Weights add to 100% ");
			 } else if (WeightTest != 100) {
				Console.WriteLine ("Grades add to " + WeightTest + " not 100. Please try again.");
			 } else
				return;
			}

				//not finalized
				public static string GradeLetterLogic()
				{
					if (FinalGrade == 100){
						GradeLetter = ", an A+ ";
					}
					else if (FinalGrade >= 93) {
						GradeLetter = ", an A ";
					}
					else if (FinalGrade >= 90) {
						GradeLetter = ", an A- ";
					}
					else if (FinalGrade >= 87) {
						GradeLetter = ", a B+ ";
					}
					else if (FinalGrade >= 83) {
						GradeLetter = ", a B ";
					}
					else if (FinalGrade >= 80) {
						GradeLetter = ", a B- ";
					}
					else if (FinalGrade >= 77) {
						GradeLetter = ", a C+ ";
					}
					else if (FinalGrade >= 73) {
						GradeLetter = ", a C ";
					}
					else if (FinalGrade >= 70) {
						GradeLetter = ", a C- ";
					}
					else if (FinalGrade >= 67) {
						GradeLetter = ", a D+ ";
					}
					else if (FinalGrade >= 63) {
						GradeLetter = ", a D ";
					}
					else if (FinalGrade >= 60) {
						GradeLetter = ", a D- ";
					}
					else if (FinalGrade < 60, > 0) {
						GradeLetter = ", a F ";
					}
					else if (FinalGrade >100 , <0){
						GradeLetter = (GradeNotInRangeString);
					}
				}
				//not finalized
				public void GradeLetterLogicChecker ()
				{	
					if (GradeLetterLogic != GradeNotInRangeString){
						bool Success = true;
						Console.WriteLine("Your grade is " + FinalGrade + LetterGradeMsg);
					}
					else 
					{
						bool Success = false;
						Console.WriteLine(GradeNotInRangeString);
					}
				}
			}
		}		
				//extra leftover code, double check
				/*
				LetterGradeMsg = GradeLetter;
				Console.WriteLine("Your grade is " + FinalGrade + LetterGradeMsg);	
				*/
				
				
				

			
		}
