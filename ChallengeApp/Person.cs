namespace ChallengeApp;
public abstract class Person
{
    public Person(string name, string surname, string sex, string age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Sex = sex;
        this.Age = age;
    }
    public Person(string name, string surname, string sex)
    {
        this.Name = name;
        this.Surname = surname;
        this.Sex = sex;
        this.Age = "no age";
    }
    public Person(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;
        this.Sex = "no sex";
        this.Age = "no age";
    }
    public Person(string name)
    {
        this.Name = name;
        this.Surname = "no surname";
        this.Sex = "no sex";
        this.Age = "no age";
    }
    public Person()
    {
        this.Name = "no name";
        this.Surname = "no surname";
        this.Sex = "no sex";
        this.Age = "no age";
    }
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public string Sex { get; private set; }
    public string Age { get; private set; }
}