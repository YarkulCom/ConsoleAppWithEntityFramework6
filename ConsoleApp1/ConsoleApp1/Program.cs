using ConsoleApp1;
using Microsoft.EntityFrameworkCore;

var yarkulDbOptions = new DbContextOptionsBuilder<YarkulDbContext>()
    .UseSqlServer("Server=YKULISH-NB\\YARKULSQLEXPRESS;initial catalog=YarkulTestDb1;" +
    "Integrated Security=true;MultipleActiveResultSets=true;App=ConsoleApp1")
    .Options;

using (var yarkulDbContext = new YarkulDbContext(yarkulDbOptions))
{
    var persons = yarkulDbContext.Persons.ToList();

    foreach (var person in persons)
    {
        Console.WriteLine($"Hello {person.FirstName} {person.LastName}");
    }
}