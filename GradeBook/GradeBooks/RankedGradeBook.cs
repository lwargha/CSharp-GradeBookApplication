namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        RankedGradeBook(string name) : base(name) { 
            Type = Enums.GradeBookType.Ranked;
        }
    }
}