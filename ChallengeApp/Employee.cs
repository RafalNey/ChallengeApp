namespace ChallengeApp
{
    public class Employee
    // klasa Pracownik (imie, nazwisko, wiek)
    {
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        // Lista punktow pracownika z wyliczeniem ich sumy
        private List<int> score = new List<int>();
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int newScore)
        {
            this.score.Add(newScore);
        }
    }
}