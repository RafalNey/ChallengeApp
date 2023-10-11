namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        // abstrakcyjne wydmuszki do liczenia punktow
        public abstract void AddGrade(float grade);
        public abstract void AddGrade(int grade);
        public abstract void AddGrade(long grade);
        public abstract void AddGrade(ulong grade);
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(string grade);
        //statystyki z pliku Statistics
        public abstract Statistics GetStatistics();
    }
}