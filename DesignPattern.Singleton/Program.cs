using DesignPattern.Singleton.Services;

var plantServiceInstance = PlantService.GetInstance();
var plants = await plantServiceInstance.GetAll();

foreach (var plant in plants)
{
    Console.WriteLine($"Plant Name: {plant.Name}");
    Console.WriteLine($"Planting Date: {plant.PlantingDate}");
    Console.WriteLine($"Planting Date: {plant.GrowthDuration}");
    Console.WriteLine($"Planting Date: {plant.WateringSchedule}");
    Console.WriteLine($"Description: {plant.Description}");
    Console.WriteLine();
}

Console.WriteLine("===================================" +
                  "=============================");

var toDoServiceInstance = ToDoService.GetInstance();
var toDos = await toDoServiceInstance.GetAll();

foreach (var toDo in toDos)
{
    Console.WriteLine($"Description: {toDo.Description}");
    Console.WriteLine($"Created On: {toDo.CreatedOn}");
    Console.WriteLine($"Due Date: {toDo.DueDate}");
    Console.WriteLine();
}