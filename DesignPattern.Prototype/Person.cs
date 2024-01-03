using DesignPattern.Prototype.Interfaces;

namespace DesignPattern.Prototype;

public class Person : IPersonPrototype
{
    public string Name { get; set; }
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }
    public string SoccerClub { get; set; }
    
    public Person(string name, int age, DateTime birthDate, string soccerClub)
    {
        Name = name;
        Age = age;
        BirthDate = birthDate;
        SoccerClub = soccerClub;
    }
    
    public IPersonPrototype Clone() => (Person) MemberwiseClone();
}