using EFCore.Context;
using EFCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

// var buider = new ConfigurationBuilder();
// buider.SetBasePath(Directory.GetCurrentDirectory());
// buider.AddJsonFile("appsettings.json");
// var config = buider.Build();
// var connectionString = config.GetConnectionString("DefaultConnection");
//  
// var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
// var options = optionsBuilder.UseNpgsql(connectionString).Options;

//Create
using (ApplicationContext context = new ApplicationContext())
{
    context.Add(new User(){Name = "Ahliddin", Email = "ahliddin@gmail.com", Age = 20});
    context.Add(new User(){Name = "Mavlono", Email = "mavlono@gmail.com", Age = 19});
    context.Add(new User(){Name = "Abduqahhor", Email = "abduqahhor@gmail.com", Age = 19});
    context.SaveChanges();
}

//Read
using (ApplicationContext context = new ApplicationContext())
{
    IEnumerable<User> users = context.Users.ToList();
    foreach (var user in users)
    {
        Console.WriteLine($"{user.Id}  {user.Name}  {user.Email}  {user.Age}");
    }
}

//Update
using (ApplicationContext context = new ApplicationContext())
{
    context.Update(new User() { Id = 1, Name = "Abduqahhor", Email = "ismonov@gamil.com", Age = 19 });
    context.SaveChanges();
}

//Delete
using (ApplicationContext context = new ApplicationContext())
{
    context.Remove(new User() { Id = 1, Name = "Abduqahhor", Email = "ismonov@gamil.com", Age = 19 });
    context.SaveChanges();
}

