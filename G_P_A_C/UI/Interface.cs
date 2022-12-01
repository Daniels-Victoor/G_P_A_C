using G_P_A_C.Main;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_P_A_C.UI
{
    public class UserInput
    {
        //This method takes in number of courses offered, course score, course unit and course code.

        public void TakeInputs()
        {

            ArrayList Course_Unit = new ArrayList();
            ArrayList Course_Score = new ArrayList();
            ArrayList Course_Code = new ArrayList();

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            string textToEnter = "GPAC ONBOARDING";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            
            
            Console.WriteLine("\nWELCOME TO GPAC CALCULATOR\n" +
                "\nYOU HAVE COME TO THE END OF A SPRINT, THE END OF THE ACADEMIC SESSION.\n" +
                "\nTO GET STARTED, CAREFULLY ENTER YOUR COURSE CODE, COURSE UNIT AND COURSE CORE BELOW,\n" +
                "TO CALCULATE YOUR GRADE POINT AVERAGE (GPA).\n" +
                "\nCOURSE CODE IS ALFA- NUMERIC (example C#101, MTH101), AND COURSE UNIT, A POSITIVE INTEGER,\n" +
                "COURSE SCORE RANGE BETWEEN 0 -100, AND CANNOT HOLD A NEGATIVE NUMBER.\n" +
                "\n" +
                "\nWE WISH YOU THE BEST\n" +
                "GPAC TEAM\n ");

            Console.ReadLine();
            Console.Clear();
           // Console.ReadLine();

            //Request for the users number of courses, then converts it to an integer.
            Console.Write("ENTER NUMBER OF REGISTERED COURSES: ");
            string NumOfCourse = Console.ReadLine();
            int NumOfCourses;

            //This loop will validate users entry of valid number of courses.
            while (!int.TryParse(NumOfCourse, out NumOfCourses))
            {
                Console.Clear();
                Console.WriteLine("Input number of courses must be a number");
                Console.WriteLine("*************");
                Console.WriteLine("*************");
                Console.Write("Oops.. Enter the correct number of courses registered: ");

                NumOfCourse = Console.ReadLine();
            }

            for (int i = 0; i < NumOfCourses; i++)
            {
                Console.Write($"What is the Course code (e.g C#101): ");
                Course_Code.Add(Console.ReadLine().ToUpper());


                Console.Write($"What is the Course unit for {Course_Code[i]}: ");
                string CourseUnit = Console.ReadLine();

                int Course_Units;
                while (!int.TryParse(CourseUnit, out Course_Units))
                {

                    Console.Write("Oops.. Input a valid number of your Course unit ");
                    CourseUnit = Console.ReadLine();

                }
                Course_Unit.Add(Course_Units);


                Console.Write($"What is the score for {Course_Code[i]}: ");
                string Course_Scores = Console.ReadLine();
                double CourseScore;
                while (!double.TryParse(Course_Scores, out CourseScore))
                {
                    Console.Write("Oops.. Input a valid number of your Course score ");
                    Course_Scores = Console.ReadLine();

                }
                Course_Score.Add(CourseScore);

                Console.WriteLine("*************");
                Console.WriteLine("*************");

            }
            Console.Clear();

            var GradeCalculation = new GradeCalculations(Course_Code, Course_Unit, Course_Score, NumOfCourses);
            GradeCalculation.Calculator();
        }
    }
}
