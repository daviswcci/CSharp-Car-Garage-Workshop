using Summer2022_Car_Garage_Program;

// Let's build out a skeleton. Let's get it working with no functionality. 
// Let's figure out what tools we have to work with, and how they fit into our greater project
// flesh out functionality
// PARRALLELISM! 

// menus and GUI
// 'isRunning' - are we working with this application?
// use 'isRunning' within a while loop
// Console.ReadLine() <- this is a sign that our application will pause at that point
// some kind of while loop that represents the application running. Then, inside that while loop, we'll have 
// a few different options presented to the user via some way, with console.readlines() there to indicate user choice

Console.WriteLine("Welcome to Dave's Garage!");
Console.WriteLine("How many vehicles would you like your garage to store?");
int capacity;
try
{
    capacity = Int32.Parse(Console.ReadLine()); 
    // are all values of capacity valid for setting up our garage?
    // if not, what changes would we make to address that?
}
catch (Exception e)
{
    capacity = 5;
}
Console.Clear();
Console.WriteLine("Your garage will store " + capacity + " vehicles!");
Console.WriteLine("Press enter to continue.");
Console.ReadLine();
Garage garage = new Garage(capacity); 
Vehicle activeVehicle;

Console.Clear();
Console.WriteLine("What type of vehicle would you like to start with?");
Console.WriteLine("1. Car \n2. Bicycle");
int vehicleType;
try
{
    vehicleType = Int32.Parse(Console.ReadLine());
    // are all values valid for selecting our car?
}
catch (Exception e)
{
    vehicleType = 1;
}

// THIS IS WHERE YOU WOULD ASK THE USER A BUNCH OF QUESTIONS AND USE THOSE ANSWERS TO BUILD YOUR CUSTOM VEHICLE
if(vehicleType == 1)
{
    // create a car
    activeVehicle = new Car();
}
else
{
    // create a bike
    activeVehicle = new Bicycle("Ozone", false, BikeType.Mountain);
}
garage.Vehicles.Add(activeVehicle);
Console.Clear();
// can we use a ternary statement (if/else) to adapt this so that the info printed is easier to interpret?
Console.WriteLine("You added a " + activeVehicle.GetType() + " to the garage.");
Console.WriteLine("Press enter to continue.");
Console.ReadLine();

bool isRunning = true;
while (isRunning)
{
    // try-catch block
    // we are going to TRY to do a portion of code. If we cannot, we run the catch block.

    Console.Clear();
    Console.WriteLine("Welcome to Dave's Garage!");
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("0. Quit \n1. Accelerate \n2. Brake \n3. Swap Vehicles \n4. Add Vehicle \n5. Remove Vehicle \n6. Display Vehicles");
    int input;
    try
    {
        input = Int32.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {
        input = -1;
    }

    switch (input)
    {
        case -1:
            Console.Clear();
            Console.WriteLine("Please type a numeric value.");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            break;
        case 0:
            isRunning = false;
            break;
        case 1:
            isRunning = false;
            break;
        case 2:
            isRunning = false;
            break;
        case 3:
            isRunning = false;
            break;
        case 4:
            isRunning = false;
            break;
        case 5:
            Console.Clear();
            Console.WriteLine("What vehicle would you like to remove?");
            for(int i = 0; i < garage.Vehicles.Count; i++)
            {
                if(garage.Vehicles[i].GetType() == typeof(Car))
                {
                    Car temp = (Car)garage.Vehicles[i];
                    Console.WriteLine(i + ". " + temp.Make + " - " + temp.Model);
                } 
                else if(garage.Vehicles[i].GetType() == typeof(Bicycle))
                {
                    Bicycle temp = (Bicycle)garage.Vehicles[i];
                    Console.WriteLine(i + ". " + temp.Brand);
                }
            }
            int vehicleChoice;
            try
            {
                vehicleChoice = Int32.Parse(Console.ReadLine());
                // if else statement to check if the Vehicles[vehicleChoice] is the same as activeVehicle
                if(garage.Vehicles[vehicleChoice] == activeVehicle)
                {
                    Console.Clear();
                    Console.WriteLine("You can't remove the vehicle you're driving!");
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                } 
                else
                {
                    garage.Vehicles.RemoveAt(vehicleChoice);
                    Console.Clear();
                    Console.WriteLine("You removed vehicle " + vehicleChoice);
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("You did not remove a vehicle.");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }
            break;
        case 6:
            isRunning = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("I don't understand that option.");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            break;
    }
}