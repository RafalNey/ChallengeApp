namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        // Delegatura
        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        public virtual event GradeAddedDelegate? GradeAdded;

        // Szablon pracownika
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        // Abstrakcyjne wydmuszki do liczenia punktow
        public abstract void AddGrade(float grade);
        public abstract void AddGrade(int grade);
        public abstract void AddGrade(long grade);
        public abstract void AddGrade(ulong grade);
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(string grade);

        // Statystyki z pliku Statistics
        public abstract Statistics GetStatistics();
    }
}