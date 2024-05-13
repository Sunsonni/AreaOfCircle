using System.Runtime.CompilerServices;
using AreaOfCircle;

Console.WriteLine("Please enter a radius for a circle");

float radius;
do
{
    string userInput = Console.ReadLine()!;
    if (userInput == "" || !Single.TryParse(userInput, out float value)) 
        {
            Console.WriteLine("Exiting program");
            Environment.Exit(0);
    }
    
    radius = Single.Parse(userInput);  
    if (radius < 0)
    {
        Console.WriteLine("Radius can't be negative.");
    }
} while (radius < 0);


Console.WriteLine($"The area of a circle with a radius of {radius} is: {Circle.AreaCircle(radius)}");

Console.WriteLine($"The circumference is: {Circle.Circumference(radius)}");
Console.WriteLine($"The diameter is: {Circle.Diameter(radius)}");

Console.WriteLine("What is the miles per gallon of your car?");
float milesPerGallon = Int32.Parse(Console.ReadLine()!);

Console.WriteLine($"{Circle.GallonsForTrip(milesPerGallon, radius)}");

