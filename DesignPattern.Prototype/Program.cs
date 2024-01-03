using DesignPattern.Prototype;

var diegoJota = new Person("Diego Jota", 27, Convert.ToDateTime("10/04/1996"), "Liverpool");

var mohamedSalah = (Person) diegoJota.Clone();

Console.WriteLine("Original Values:");
Console.WriteLine(
    $"Name: {diegoJota.Name}, Age: {diegoJota.Age}, Birth Date: {diegoJota.BirthDate}, Soccer Club: {diegoJota.SoccerClub}");
Console.WriteLine(
    $"Name: {mohamedSalah.Name}, Age: {mohamedSalah.Age}, Birth Date: {mohamedSalah.BirthDate}, Soccer Club: {mohamedSalah.SoccerClub}");

Console.WriteLine("\nValues After Changes:");
mohamedSalah.Name = "Mohamed Salah";
mohamedSalah.Age = 31;
mohamedSalah.BirthDate = Convert.ToDateTime("6/14/1992");

Console.WriteLine(
    $"Name: {diegoJota.Name}, Age: {diegoJota.Age}, Birth Date: {diegoJota.BirthDate}, Soccer Club: {diegoJota.SoccerClub}");
Console.WriteLine(
    $"Name: {mohamedSalah.Name}, Age: {mohamedSalah.Age}, Birth Date: {mohamedSalah.BirthDate}, Soccer Club: {mohamedSalah.SoccerClub}");

Console.ReadKey();