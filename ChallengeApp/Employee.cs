namespace ChallengeApp
{
    public class Employee
    // klasa Pracownik (imie, nazwisko)
    {
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        // Lista punktow pracownika
        private List<float> grades = new List<float>();

        //Dodawanie punktow pracownikowi
        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }

        //Wyliczanie max, min oraz sredniej dla pracownika
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0.00f;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}