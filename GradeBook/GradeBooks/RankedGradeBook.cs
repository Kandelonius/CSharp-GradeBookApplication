using GradeBook.Enums;
using Newtonsoft.Json;
using System;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        private static string name;

        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
{
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
            }
            else if (averageGrade >= 80)
            {
                return 'A';
            }
            else if (averageGrade >= 60)
            {
                return 'B';
            }
            else if (averageGrade >= 40)
            {
                return 'C';
            }
            else if(averageGrade >= 20)
            {
                return 'D';
            }
            return 'F';
        }
    }
}
