using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        private static string name;

        public StandardGradeBook(string ) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}
