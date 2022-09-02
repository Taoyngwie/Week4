
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("tao");
        /*
        Car myCar = new Car();
        myCar.band = "Toyota";
        myCar.model = "Altis";
        myCar.numberOfDoors = 4;
        myCar.numberOfWheels = 4;

        Car Benz = new Car();
        Benz.band = "Benz";
        Benz.model = "C-300";
        Benz.numberOfDoors = 4;
        Benz.numberOfWheels = 4;

        PrintCarInformation(myCar);
        PrintCarInformation(Benz);
        
        Door d1 = new Door();
        Console.WriteLine("Door check");
        Console.WriteLine(d1.isDoorCheck());
        Console.WriteLine("Close door");
        d1.CloseDoor();
        Console.WriteLine("Door check");
        Console.WriteLine(d1.isDoorCheck());
    

        //ประตูหมา
        DogDoor d1 = new DogDoor();
        d1.Open();
        d1.Close();
        Console.WriteLine("Door is open {0}", d1.IsOpen());
        d1.checkBool();
        

        ChangUnit ch1 = new ChangUnit(12);
        Console.WriteLine(ch1.footToInch());
        */

        ChangUnit feetToInchesConverter = new ChangUnit(12);
        ChangUnit milesToFeetConverter = new ChangUnit(5280);

        Console.WriteLine("Feet to inches: {0}",
        feetToInchesConverter.Convert(30));

        Console.WriteLine("Miles to Feet: {0}",
        milesToFeetConverter.Convert(1));

        Console.WriteLine("Feet to Inches from miles: {0}",
        feetToInchesConverter.Convert(milesToFeetConverter.Convert(2)));


    }

    static void PrintCarInformation(Car car)
    {
        Console.WriteLine("*********************");
        Console.WriteLine("Band: {0}", car.band);
        Console.WriteLine("Model: {0}", car.model);
        Console.WriteLine("Number of Door: {0}", car.numberOfDoors);
        Console.WriteLine("Number of Wheel: {0}", car.numberOfWheels);
        Console.WriteLine(car.MoveBackward());
        Console.WriteLine(car.MoveBackward());
        Console.WriteLine(car.Turn());
        Console.WriteLine(car.Stop());
        Console.WriteLine("*********************");
    }


}

