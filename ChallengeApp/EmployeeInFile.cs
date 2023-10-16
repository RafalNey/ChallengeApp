namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate? GradeAdded;
        // Nazwa pliku z danymi 
        private const string fileName = "grades.txt";
        // Lista dozwolonych liter jako punktow
        public char[] specialLetters = { 'A', 'a', 'B', 'b', 'C', 'c', 'D', 'd', 'E', 'e' };
        public EmployeeInFile(string name, string surname) : base(name, surname)
        {
        }
        public override void AddGrade(float grade)
        {
            float result = (float)grade;
            if (result < 0 || result > 100)
            {
                throw new Exception("Ocena liczbowa musi byc z przedzialu od 0 do 100.");
            }
            else
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
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
            var gradesFromFile = this.ReadGradesFromFile();
            var results = this.CountStatistics(gradesFromFile);
            return results;
        }
        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var grade = float.Parse(line);
                        grades.Add(grade);
                        line = reader.ReadLine();
                        if (GradeAdded != null)
                        {
                            GradeAdded(this, new EventArgs());
                        }
                    }
                }
            }
            else
            {
                throw new Exception("Plik z danymi nie istnieje");
            }
            return grades;
        }
        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();

            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}