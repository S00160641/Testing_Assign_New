using fit;
using TestingAssignment;

namespace TestingAssignmentFit
{
    public class FitTest : ColumnFixture
    {
        public string Gender { get; set; }
        public int Age { get; set; }
        public float Premium()
        {
            var sut = new Program();
            var result = sut.CalcPremium(Age, Gender);
            return result;
        }
    }
}
