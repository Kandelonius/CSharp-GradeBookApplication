using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        private static string name;

        public StandardGradeBook() : base(name)
        {
        }
    }
}
