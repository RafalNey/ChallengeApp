namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public Supervisor(string name, string surname)
        {
            this.Name = name; ;
            this.Surname = surname;
        }
        public string Name { get; set; }
        public string Surname { get; set; }

        // Lista punktow superwisiora
        private List<float> grades = new List<float>();

        // Lista dozwolonych cyfr z plusami i minusami jako punktow
        public string[] specialGrades = { "1", "-1", "1-", "+1", "1+", "2", "-2", "2-", "+2", "2+", "3", "-3", "3-", "+3", "3+", "4", "-4", "4-", "+4", "4+", "5", "-5", "5-", "+5", "5+", "6", "-6", "6-", "+6", "6+" };

        // Dodawanie punktow superwisiorowi. Punkty sa tylko od 0 do 100.
        public void AddGrade(string grade)
        {
            if (specialGrades.Contains(grade))
            {
                switch (grade)
                {
                    case "1":
                    case "-1":
                    case "1-":
                        this.AddGrade(0);
                        break;
                    case "+1":
                    case "1+":
                        this.AddGrade(5);
                        break;
                    case "-2":
                    case "2-":
                        this.AddGrade(15);
                        break;
                    case "2":
                        this.AddGrade(20);
                        break;
                    case "+2":
                    case "2+":
                        this.AddGrade(25);
                        break;
                    case "-3":
                    case "3-":
                        this.AddGrade(35);
                        break;
                    case "3":
                        this.AddGrade(40);
                        break;
                    case "+3":
                    case "3+":
                        this.AddGrade(45);
                        break;
                    case "-4":
                    case "4-":
                        this.AddGrade(55);
                        break;
                    case "4":
                        this.AddGrade(60);
                        break;
                    case "+4":
                    case "4+":
                        this.AddGrade(65);
                        break;
                    case "-5":
                    case "5-":
                        this.AddGrade(75);
                        break;
                    case "5":
                        this.AddGrade(80);
                        break;
                    case "+5":
                    case "5+":
                        this.AddGrade(85);
                        break;
                    case "-6":
                    case "6-":
                        this.AddGrade(95);
                        break;
                    case "6":
                    case "+6":
                    case "6+":
                        this.AddGrade(100);
                        break;
                    default:
                        throw new Exception("Niewlasciwa ocena. Tylko od 1 do 6.");
                }
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
        public void AddGrade(float grade)
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

        // Wyliczanie max, min oraz sredniej dla superwisiora
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

                // zamiana sredniej na cyferke
                switch (statistics.Average)
                {
                    case var average when average == 100:
                        statistics.AverageDigit = "6";
                        break;
                    case var average when average >= 95:
                        statistics.AverageDigit = "-6";
                        break;
                    case var average when average >= 85:
                        statistics.AverageDigit = "5+";
                        break;
                    case var average when average >= 80:
                        statistics.AverageDigit = "5";
                        break;
                    case var average when average >= 75:
                        statistics.AverageDigit = "-5";
                        break;
                    case var average when average >= 65:
                        statistics.AverageDigit = "4+";
                        break;
                    case var average when average >= 60:
                        statistics.AverageDigit = "4";
                        break;
                    case var average when average >= 55:
                        statistics.AverageDigit = "-4";
                        break;
                    case var average when average >= 45:
                        statistics.AverageDigit = "3+";
                        break;
                    case var average when average >= 40:
                        statistics.AverageDigit = "3";
                        break;
                    case var average when average >= 35:
                        statistics.AverageDigit = "-3";
                        break;
                    case var average when average >= 25:
                        statistics.AverageDigit = "2+";
                        break;
                    case var average when average >= 20:
                        statistics.AverageDigit = "2";
                        break;
                    case var average when average >= 15:
                        statistics.AverageDigit = "-2";
                        break;
                    case var average when average >= 5:
                        statistics.AverageDigit = "1+";
                        break;
                    case var average when average == 0:
                        statistics.AverageDigit = "1";
                        break;
                    default:
                        statistics.AverageDigit = "1";
                        break;
                }
                return statistics;
            }
            else //statystyki dla superwisiora bez ocen
            {
                var statistics = new Statistics();

                statistics.Average = 0.00f;
                statistics.Max = 0;
                statistics.Min = 0;
                statistics.AverageDigit = "1";

                return statistics;
            }
        }
    }
}