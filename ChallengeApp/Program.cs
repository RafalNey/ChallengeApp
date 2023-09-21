using System.Reflection.Metadata;
using System.Security;
using ChallengeApp;

//dodawanie pracownikow
var employee1 = new Employee("Adam", "Kamizelich", 33);
var employee2 = new Employee("Rafal", "Ney", 53);
var employee3 = new Employee("Monika", "Dziewczyna-Ratownika", 18);
var employee4 = new Employee("Zuzia", "Nieduza", 25);

// przyznawanie losowych punktow pracownikowi (zeby bylo uczciwiej)
List<Employee> employees = new List<Employee>()
{ employee1, employee2, employee3, employee4 };

foreach (var employee in employees)
{
    for (int i = 0; i < 5; i++)
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 11);
        employee.AddScore(randomNumber); ;
    }
}
// wybor pracownika o najwiekszej sumie punktow
Employee employeeWithMaxResult = null;
int maxResult = 0;
foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}
Console.WriteLine(employeeWithMaxResult.Name + ", " + employeeWithMaxResult.Surname + ", lat: " + employeeWithMaxResult.Age + ", suma ocen: " + employeeWithMaxResult.Result);
