namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        void AddGrade(float grade);
        void AddGrade(int grade);
        void AddGrade(long grade);
        void AddGrade(ulong grade);
        void AddGrade(double grade);
        void AddGrade(string grade);
        Statistics GetStatistics();
    }
}