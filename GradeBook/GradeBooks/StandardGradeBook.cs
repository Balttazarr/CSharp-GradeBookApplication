using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public string Name { get; set; }

        public StandardGradeBook(string name) : base(name)
        {
            Name = name;
            Type = GradeBookType.Standard;
        }

    }
}
