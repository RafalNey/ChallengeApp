// namespace ChallengeApp
// {
//     public class Supervisor : EmployeeBase
//     {
//         public override event GradeAddedDelegate GradeAdded;
//         public Supervisor(string name, string surname) : base(name, surname)
//         {
//         }
//         // Lista punktow superwisiora
//         private List<float> grades = new List<float>();
//         // Lista dozwolonych cyfr z plusami i minusami jako punktow
//         public string[] specialGrades = { "1", "-1", "1-", "+1", "1+", "2", "-2", "2-", "+2", "2+", "3", "-3", "3-", "+3", "3+", "4", "-4", "4-", "+4", "4+", "5", "-5", "5-", "+5", "5+", "6", "-6", "6-", "+6", "6+" };
//         // Dodawanie punktow superwisiorowi. Punkty sa tylko od 0 do 100.
//         public override void AddGrade(string grade)
//         {
//             if (specialGrades.Contains(grade))
//             {
//                 switch (grade)
//                 {
//                     case "1":
//                     case "-1":
//                     case "1-":
//                         this.AddGrade(0);
//                         break;
//                     case "+1":
//                     case "1+":
//                         this.AddGrade(5);
//                         break;
//                     case "-2":
//                     case "2-":
//                         this.AddGrade(15);
//                         break;
//                     case "2":
//                         this.AddGrade(20);
//                         break;
//                     case "+2":
//                     case "2+":
//                         this.AddGrade(25);
//                         break;
//                     case "-3":
//                     case "3-":
//                         this.AddGrade(35);
//                         break;
//                     case "3":
//                         this.AddGrade(40);
//                         break;
//                     case "+3":
//                     case "3+":
//                         this.AddGrade(45);
//                         break;
//                     case "-4":
//                     case "4-":
//                         this.AddGrade(55);
//                         break;
//                     case "4":
//                         this.AddGrade(60);
//                         break;
//                     case "+4":
//                     case "4+":
//                         this.AddGrade(65);
//                         break;
//                     case "-5":
//                     case "5-":
//                         this.AddGrade(75);
//                         break;
//                     case "5":
//                         this.AddGrade(80);
//                         break;
//                     case "+5":
//                     case "5+":
//                         this.AddGrade(85);
//                         break;
//                     case "-6":
//                     case "6-":
//                         this.AddGrade(95);
//                         break;
//                     case "6":
//                     case "+6":
//                     case "6+":
//                         this.AddGrade(100);
//                         break;
//                     default:
//                         throw new Exception("Niewlasciwa ocena. Tylko od 1 do 6.");
//                 }
//             }
//             else if (!float.TryParse(grade, out float result))
//             {
//                 throw new Exception("Niewlasciwy ciag znakow.");
//             }
//             else
//             {
//                 result = float.Parse(grade);
//                 this.AddGrade(result);
//             }
//         }
//         public override void AddGrade(float grade)
//         {
//             float result = (float)grade;
//             if (result < 0 || result > 100)
//             {
//                 throw new Exception("Ocena liczbowa musi byc z przedzialu od 0 do 100.");
//             }
//             else
//             {
//                 this.grades.Add(result);
//                 if (GradeAdded != null)
//                 {
//                     GradeAdded(this, new EventArgs());
//                 }
//             }
//         }
//         public override void AddGrade(int grade)
//         {
//             float result = (float)grade;
//             this.AddGrade(result);
//         }
//         public override void AddGrade(long grade)
//         {
//             float result = (float)grade;
//             this.AddGrade(result);
//         }
//         public override void AddGrade(ulong grade)
//         {
//             float result = (float)grade;
//             this.AddGrade(result);
//         }
//         public override void AddGrade(double grade)
//         {
//             float result = (float)grade;
//             this.AddGrade(result);
//         }
//         // Wyliczanie max, min oraz sredniej dla superwisiora
//         public override Statistics GetStatistics()
//         {
//             var statistics = new Statistics();

//             foreach (var grade in this.grades)
//             {
//                 statistics.AddGrade(grade);
//             }
//             return statistics;

//         }
//     }
// }