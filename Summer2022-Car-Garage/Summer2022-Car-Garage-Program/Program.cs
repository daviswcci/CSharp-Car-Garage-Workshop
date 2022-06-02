using Summer2022_Car_Garage_Program;

// variable declaration
// type name;

// assignment/reassignment
// name = value;

bool isSunny = true;

// temperature setting without ternary statements
int temperature;

if (isSunny) // condition 
{
    temperature = 90;
}
else
{
    temperature = 60;
}

// however, we can rewrite that all to be on one line.
// type variable = condition ? valT : valF; - ternary statements simplify to a value, and could be used anywhere where a value is used
int ternaryTemp = isSunny ? 90 : 60;

Console.WriteLine(temperature);
Console.WriteLine(ternaryTemp);



// How do we call a method?
Car gavinCar = new Car();
gavinCar.Accelerate(10); // increase speed from 0 to 10
Console.WriteLine(gavinCar.Speed);