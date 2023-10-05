using System.Runtime.Intrinsics.X86;
namespace ChallengeApp
{
    // klasa Pracownik (imie, nazwisko)
    public class Employee
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

        // Dodawanie punktow pracownikowi na pierdyliard sposobow. Punkty sa tylko od 0 do 100.
        public void AddGrade(float grade)
        {
            float result = (float)grade;
            if (result < 0 || result > 100)
            {
                Console.WriteLine("Ocena liczbowa musi byc z przedzialu od 0 do 100.");
            }
            else
            {
                this.grades.Add(result);
            }
        }
        public void AddGrade(int grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public void AddGrade(ulong grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        // Dodawanie punktow przy pomocy literek: A - E.
        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "A":
                case "a":
                    this.grades.Add(100);
                    break;
                case "B":
                case "b":
                    this.grades.Add(80);
                    break;
                case "C":
                case "c":
                    this.grades.Add(60);
                    break;
                case "D":
                case "d":
                    this.grades.Add(40);
                    break;
                case "E":
                case "e":
                    this.grades.Add(20);
                    break;
                default:
                    if (!float.TryParse(grade, out float result))
                    {
                        Console.WriteLine("Niewlasciwy ciag znakow. Litery tylko od A do E.");
                    }
                    else
                    {
                        result = float.Parse(grade);
                        this.AddGrade(result);
                    }
                    break;
            }
        }

        // Wyliczanie max, min oraz sredniej dla pracownika
        public Statistics GetStatistics()
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
            else
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