using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        private static string name;

        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
    }
}
