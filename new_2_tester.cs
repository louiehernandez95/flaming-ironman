		//added a section that properly loops if user fails to enter correct weights
			
			string GradeNotInRangeString = "Oops, your grade is not between 0 and 100%. Try your inputs again."
			
			//container for user input prompts
			//outputs final grade value so logic can assign letter grade
			//should be final
			public static void UserGradeInputPrompt()
			{	
				//While loop prompts for and receives user inputs, conducts calulations, complete with nested user input checker
				//should be final
				double GradeTotal = 0;
				int GradeTotalTest = 0;
				while (GradeTotalTest != 1)
				{	
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
					
					//uses an int value to determine if the while loop should continue, if in proper range assigns string value, if not in range prints error message
					int GradeTotalTest ()
					{
						if (GradeTotal <= 100 & GradeTotal >= 0){
							FinalGrade = GradeTotal;
							return 1;
						}
						else {
							return 2;
						}
					}
					if (GradeTotalTest == 2){
						Console.WriteLine (GradeNotInRangeString);
					} 
				}
			}
			
			//logic for assigning a letter grade
			//should be final
			public static string GradeLetterLogic()
			{
				string LetterGradeMsg, GradeLetter;
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
				else if (FinalGrade < 60 & > 0) {
					GradeLetter = ", a F ";
				}
				else if (FinalGrade > 100 | < 0){
					GradeLetter = (GradeNotInRangeString);
				}
			}
			
			//checks assigned letter grade for validity and prints final message to user
			//if not in range, prints error and returns to start of programs for user input
			//should be finalized
			public void GradeLetterLogicChecker ()
			{	
				bool Success;
				if (GradeLetterLogic != GradeNotInRangeString){
					bool Success = true;
					Console.WriteLine("Your grade is " + FinalGrade + LetterGradeMsg);
				} else 
					{
					bool Success = false;
					Console.WriteLine(GradeNotInRangeString);
					}
				if (bool Success = false){
				return;
				}
			}
			//if program gets this far, all checks passed, in theory
			Console.WriteLine("Code tests passed!");