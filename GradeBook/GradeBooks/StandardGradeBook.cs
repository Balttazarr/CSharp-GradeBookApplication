using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public string Name { get; set; }

        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Name = name;
            Type = GradeBookType.Standard;
            IsWeighted = isWeighted;
        }


    }
}
