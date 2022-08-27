/* Write a program that asks the user to enter the speed limit.
 * Once the speed limit is set, the program should ask the speed of the vehicle.
   If the speed of the vehicle is below or equal to the speed limit, the program
   should display 'Ok'.  
   If the speed of the vehicle is above the speed limit, the program should
   calculate the number of demerit points.
   - For every 5mph above the speed limit => 1 demerit point.
   - If demerit points > 12 => License is suspended.*/

Console.Write("What is the speed limit? ");
byte speedLimit = Convert.ToByte(Console.ReadLine());

Console.Write("How fast is the vehicle going? ");
byte speedOfVehicle = Convert.ToByte(Console.ReadLine());

CalculateDemeritPoints(speedLimit, speedOfVehicle);


void CalculateDemeritPoints(byte speedLimit, byte speedOfVehicle)
{
    const byte mphPerDemeritPoint = 5;
    var demeritPoints = (speedOfVehicle - speedLimit) / mphPerDemeritPoint;

    if (speedOfVehicle <= speedLimit)
        Console.WriteLine("Ok");
    else
    {
        if (demeritPoints > 12)
            Console.WriteLine("License Suspended.");
        else
            Console.WriteLine("Demerit Point: " + demeritPoints);
    }
}