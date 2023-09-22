namespace ChallengeApp.Tests;

public class Tests
{
    [Test]
    public void AddScoresOneTimeToOneEmployee()
    {
        // arrange
        var employee1 = new Employee("Adam", "Kamizelich", 33);
        List<Employee> employees = new List<Employee>()
        { employee1 };

        //act
        employee1.AddScore(5);
        //asert
        Assert.That(employee1.Result, Is.EqualTo(5));
    }
    [Test]
    public void AddScoresFewTimesToOneEmployee()
    {
        // arrange
        var employee1 = new Employee("Adam", "Kamizelich", 33);
        List<Employee> employees = new List<Employee>()
        { employee1 };

        //act
        employee1.AddScore(5);
        employee1.AddScore(10);
        employee1.AddScore(6);
        employee1.AddScore(4);

        //asert
        Assert.That(employee1.Result, Is.EqualTo(25));
    }
    [Test]
    public void AddScoresFewTimesToFewEmployees()
    {
        // arrange
        var employee1 = new Employee("Adam", "Kamizelich", 33);
        var employee2 = new Employee("Rafal", "Ney", 53);
        var employee3 = new Employee("Monika", "Dziewczyna-Ratownika", 18);
        var employee4 = new Employee("Zuzia", "Nieduza", 25);

        List<Employee> employees = new List<Employee>()
        { employee1, employee2, employee3, employee4 };

        //act
        employee1.AddScore(1);
        employee1.AddScore(1);
        employee1.AddScore(1);
        employee2.AddScore(2);
        employee2.AddScore(2);
        employee2.AddScore(2);
        employee3.AddScore(3);
        employee3.AddScore(3);
        employee3.AddScore(3);
        employee4.AddScore(4);
        employee4.AddScore(4);
        employee4.AddScore(4);

        //asert
        Assert.That(employee1.Result + employee2.Result + employee3.Result + employee4.Result, Is.EqualTo(3 + 6 + 9 + 12));
    }
    [Test]
    public void AddNegativeScoresOneTimeToOneEmployee()
    {
        // arrange
        var employee1 = new Employee("Adam", "Kamizelich", 33);
        List<Employee> employees = new List<Employee>()
        { employee1 };

        //act
        employee1.AddScore(-5);

        //asert
        Assert.That(employee1.Result, Is.EqualTo(-5));
    }
    [Test]
    public void AddNegativeScoresFewTimesToOneEmployee()
    {
        // arrange
        var employee1 = new Employee("Adam", "Kamizelich", 33);
        List<Employee> employees = new List<Employee>()
        { employee1 };

        //act
        employee1.AddScore(-5);
        employee1.AddScore(-10);
        employee1.AddScore(-6);
        employee1.AddScore(-4);

        //asert
        Assert.That(employee1.Result, Is.EqualTo(-25));
    }
    [Test]
    public void AddNegativeScoresFewTimesToFewEmployees()
    {
        // arrange
        var employee1 = new Employee("Adam", "Kamizelich", 33);
        var employee2 = new Employee("Rafal", "Ney", 53);
        var employee3 = new Employee("Monika", "Dziewczyna-Ratownika", 18);
        var employee4 = new Employee("Zuzia", "Nieduza", 25);

        List<Employee> employees = new List<Employee>()
        { employee1, employee2, employee3, employee4 };

        //act
        employee1.AddScore(-1);
        employee1.AddScore(-1);
        employee1.AddScore(-1);
        employee2.AddScore(-2);
        employee2.AddScore(-2);
        employee2.AddScore(-2);
        employee3.AddScore(-3);
        employee3.AddScore(-3);
        employee3.AddScore(-3);
        employee4.AddScore(-4);
        employee4.AddScore(-4);
        employee4.AddScore(-4);

        //asert
        Assert.That(employee1.Result + employee2.Result + employee3.Result + employee4.Result, Is.EqualTo(-3 - 6 - 9 - 12));
    }
    [Test]
    public void WhatIfTryingToAddZeroToOneEmployee()
    {
        // arrange
        var employee1 = new Employee("Adam", "Kamizelich", 33);
        List<Employee> employees = new List<Employee>()
        { employee1 };

        //act
        employee1.AddScore(0);

        //asert
        Assert.That(employee1.Result, Is.EqualTo(0));
    }
}