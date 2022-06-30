using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        private static string name;

        public StandardGradeBook(string name, bool IsWeighted) : base(name, IsWeighted)
        {
            Type = GradeBookType.Standard;
            bool isWeighted = IsWeighted;
        }
    }
}
