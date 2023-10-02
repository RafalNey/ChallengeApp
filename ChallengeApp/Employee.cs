using System.Runtime.Intrinsics.X86;
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

        //Dodawanie punktow pracownikowi. Punkty sa tylko od 0 do 100.
        public void AddGrade(float grade)
        {
            float result = (float)grade;
            if (result < 0 || result > 100)
            {
                Console.WriteLine("Grade should be in the range from 0 to 100.");
            }
            else
            {
                this.grades.Add(result);
            }
        }
        public void AddGrade(int grade)
        {
            float result = (float)grade;
            if (result < 0 || result > 100)
            {
                Console.WriteLine("Grade should be in the range from 0 to 100.");
            }
            else
            {
                this.grades.Add(result);
            }
        }
        public void AddGrade(long grade)
        {
            float result = (float)grade;
            if (result < 0 || result > 100)
            {
                Console.WriteLine("Grade should be in the range from 0 to 100.");
            }
            else
            {
                this.grades.Add(result);
            }
        }
        public void AddGrade(double grade)
        {
            float result = (float)grade;
            if (result < 0 || result > 100)
            {
                Console.WriteLine("Grade should be in the range from 0 to 100.");
            }
            else
            {
                this.grades.Add(result);
            }
        }
        public void AddGrade(string grade)
        {
            if (!float.TryParse(grade, out float result))
            {
                Console.WriteLine("This string cannot be parse to float.");
            }
            else
            {
                result = float.Parse(grade);
                if (result < 0 || result > 100)
                {
                    Console.WriteLine("Grade should be in the range from 0 to 100.");
                }
                else
                {
                    this.grades.Add(result);
                }
            }
        }
        //Wyliczanie max, min oraz sredniej dla pracownika
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
                return statistics;
            }
            else
            {
                var statistics = new Statistics();

                statistics.Average = 0.00f;
                statistics.Max = 0;
                statistics.Min = 0;
                return statistics;
            }
        }
    }
}