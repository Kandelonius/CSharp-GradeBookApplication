using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        private static string name;

        public RankedGradeBook() : base(name)
        {
            this.Type = GradeBookType.Ranked;
        }
    }
}
