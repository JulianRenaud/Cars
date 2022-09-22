using ClassesExercise;
using System.Diagnostics;
using System.Reflection;

var Car_1 = new Car();

Car_1.Price = "$123,000";
Car_1.Brand = "Corvette";
Car_1.Model = "ZR1";
Car_1.Year = 2022;
Car_1.Horsepower = 755;



Console.WriteLine($"Starting Price: {Car_1.Price}");
Console.WriteLine($"Year: {Car_1.Year}");
Console.WriteLine($"Brand: {Car_1.Brand}");
Console.WriteLine($"Model: {Car_1.Model}");
Console.WriteLine($"Horsepower: {Car_1.Horsepower}");