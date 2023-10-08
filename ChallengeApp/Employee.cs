using System.Runtime.Intrinsics.X86;
namespace ChallengeApp
{
    // klasa Pracownik (imie, nazwisko, plec, wiek)
    public class Employee : Person
    {
        public Employee(string name, string surname, string sex, string age)
        : base(name, surname, sex, age)
        {
        }
        public Employee(string name, string surname, string sex)
        : base(name, surname, sex)
        {
        }
        public Employee(string name, string surname)
        : base(name, surname)
        {
        }
        public Employee(string name)
        : base(name)
        {
        }
        public Employee()
        {
        }

        // Lista punktow pracownika
        private List<float> grades = new List<float>();

        // Lista dozwolony liter jako punktow
        public char[] specialLetters = { 'A', 'a', 'B', 'b', 'C', 'c', 'D', 'd', 'E', 'e' };

        // Dodawanie punktow pracownikowi na pierdyliard sposobow. Punkty sa tylko od 0 do 100.
        public void AddGrade(float grade)
        {
            float result = (float)grade;
            if (result < 0 || result > 100)
            {
                throw new Exception("Ocena liczbowa musi byc z przedzialu od 0 do 100.");
                // Console.WriteLine("Ocena liczbowa musi byc z przedzialu od 0 do 100.");
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
            if (grade.Length == 1 && specialLetters.Contains(grade[0]))
            {
                char result = char.Parse(grade);
                this.AddGrade(result);
            }
            else if (!float.TryParse(grade, out float result))
            {
                throw new Exception("Niewlasciwy ciag znakow.");
                // Console.WriteLine("Niewlasciwy ciag znakow.");
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
                    // Console.WriteLine("Niewlasciwy ciag znakow. Litery tylko od A do E.");
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