using Summer2022_Car_Garage_Program;

Car davisCar = new Car(); // RED FLAG! 'new' means we are creating a new object (often paired with a constuctor)
Console.WriteLine(davisCar.Model);

Car xavierCar = new Car("Chevrolet", "Camaro", 22, 100, 0, 184);
Console.WriteLine(xavierCar.Model);