namespace ChallengeApp
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public int Count { get; private set; }
        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }
        public char AverageLetter
        {
            get
            {
                switch (this.Average) // Zamiana sredniej na literke
                {
                    case var average when average > 80:
                        return 'A';
                    case var average when average > 60:
                        return 'B';
                    case var average when average > 40:
                        return 'C';
                    case var average when average > 20:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }
        public string AverageDigit
        {
            get
            {
                switch (this.Average) // Zamiana sredniej na cyferke
                {
                    case var average when average == 100:
                        return "6";
                    case var average when average >= 95:
                        return "-6";
                    case var average when average >= 85:
                        return "5+";
                    case var average when average >= 80:
                        return "5";
                    case var average when average >= 75:
                        return "-5";
                    case var average when average >= 65:
                        return "4+";
                    case var average when average >= 60:
                        return "4";
                    case var average when average >= 55:
                        return "-4";
                    case var average when average >= 45:
                        return "3+";
                    case var average when average >= 40:
                        return "3";
                    case var average when average >= 35:
                        return "-3";
                    case var average when average >= 25:
                        return "2+";
                    case var average when average >= 20:
                        return "2";
                    case var average when average >= 15:
                        return "-2";
                    case var average when average >= 5:
                        return "1+";
                    case var average when average == 0:
                        return "1";
                    default:
                        return "1";
                }
            }
        }
        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Min = float.MaxValue;
            this.Max = float.MinValue;
        }
        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Min = Math.Min(this.Min, grade);
            this.Max = Math.Max(this.Max, grade);
        }
    }
}