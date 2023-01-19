// See https://aka.ms/new-console-template for more information

//..............Fare details with time ..................

Console.WriteLine("QUESTION 2 : \n Accept a flight fare and booking time.\r\n" +
    "a. If booking time from 6am to 9am, apply 10% fare increase and print\r\n" +
    "b. If booking time from 9am to 5pm, apply 20% fare increase and print\r\n" +
    "c. If booking time from 5pm to 11pm, apply 7% fare increase and print\r\n" +
    "d. If booking time from 11pm to 6am, apply 5% fare increase and print\r\n");


Console.WriteLine("Enter flight fare : ");
double fare = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter booking time (24hr) : ");
double time = Convert.ToDouble(Console.ReadLine());


if (time > 6 && time <= 9)
{
    double newfare = fare + (fare * .10);
    Console.WriteLine(newfare);
}
else if (time > 9 && time <= 17)
{
    double newfare = fare + (fare * .20);
    Console.WriteLine(newfare);
}
else if (time > 17 && time <= 23)
{
    double newfare = (fare + fare * .07);
    Console.WriteLine(newfare);
}
else if (time > 24)
{
    Console.WriteLine("Invalid option");

}
else
{
    double newfare = (fare + fare * .05);
    Console.WriteLine(newfare);
}

