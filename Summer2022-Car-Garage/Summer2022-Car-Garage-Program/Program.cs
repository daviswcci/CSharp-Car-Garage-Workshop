using Summer2022_Car_Garage_Program;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// type nam = new type();
Car car = new Car();

Console.WriteLine(car.MPG); // this should print -1

Car anotherCar = new Car("Davis", "Chrysler", "PT Cruiser", 5, 3, 100, 250, false);

Console.WriteLine(anotherCar.MPG); // this should print 3