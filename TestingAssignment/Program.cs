namespace TestingAssignment
{
    public class Program
    {
        public float CalcPremium(int age, string gender)
        {
            float premium;

            // 1
            if (gender == "female")
            {
                // 2
                if ((age >= 18) && (age <= 30))
                    // 3
                    premium = 5.0f;
                else
                {
                    // 4
                    if (age >= 31)
                        // 5
                        premium = 2.5f;
                    else
                        // 6
                        premium = 0.0f;
                }
            }
            // 7
            else if (gender == "male")
            { 
                // 8
                if ((age >= 18) && (age <= 35))
                    // 9
                    premium = 6.0f;
                else
                {
                    // 10
                    if (age >= 36)
                        // 11
                        premium = 5.0f;
                    else
                        // 12
                        premium = 0.0f;
                }
            }
            else
                // 13
                premium = 0.0f;

            // 14
            if (age >= 50)
                // 15
                premium = premium * 0.15f;

            // 16
            return premium;
        }
    }
}