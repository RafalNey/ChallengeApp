namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        // klasa Pracownik w pamieci (imie, nazwisko)
        public EmployeeInMemory(string name, string surname)
        : base(name, surname)
        {
        }
        // Lista punktow pracownika
        private List<float> grades = new List<float>();
        // Lista dozwolonych liter jako punktow
        public char[] specialLetters = { 'A', 'a', 'B', 'b', 'C', 'c', 'D', 'd', 'E', 'e' };
        // Dodawanie punktow pracownikowi na pierdyliard sposobow. Punkty sa tylko od 0 do 100.
        public override void AddGrade(float grade)
        {
            float result = (float)grade;
            if (result < 0 || result > 100)
            {
                throw new Exception("Ocena liczbowa musi byc z przedzialu od 0 do 100.");
            }
            else
            {
                this.grades.Add(result);
            }
        }
        public override void AddGrade(int grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public override void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public override void AddGrade(ulong grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public override void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        // Dodawanie punktow przy pomocy literek: A - E.
        public override void AddGrade(string grade)
        {
            if (grade.Length == 1 && specialLetters.Contains(grade[0]))
            {
                char result = char.Parse(grade);
                this.AddGrade(result);
            }
            else if (!float.TryParse(grade, out float result))
            {
                throw new Exception("Niewlasciwy ciag znakow.");
            }
            else
            {
                result = float.Parse(grade);
                this.AddGrade(result);
            }
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Niewlasciwa litera. Litery tylko od A do E.");
            }
        }
        // Wyliczanie max, min oraz sredniej dla pracownika
        public override Statistics GetStatistics()
        {
            if (grades.Count > 0)
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
                statistics.Average = (float)Math.Round(statistics.Average /= this.grades.Count, 2);

                // zamiana sredniej na literke
                switch (statistics.Average)
                {
                    case var average when average > 80:
                        statistics.AverageLetter = 'A';
                        break;
                    case var average when average > 60:
                        statistics.AverageLetter = 'B';
                        break;
                    case var average when average > 40:
                        statistics.AverageLetter = 'C';
                        break;
                    case var average when average > 20:
                        statistics.AverageLetter = 'D';
                        break;
                    default:
                        statistics.AverageLetter = 'E';
                        break;
                }
                return statistics;
            }
            else //statystyki dla pracownika bez ocen
            {
                var statistics = new Statistics();

                statistics.Average = 0.00f;
                statistics.Max = 0;
                statistics.Min = 0;
                statistics.AverageLetter = 'E';

                return statistics;
            }
        }
    }
}