// See https://aka.ms/new-console-template for more information
using System;
using System.Drawing;

Console.WriteLine("QUESTION NO: 3 \n Accept 10 flight fares in decimal format into an array: \r\n" +
    "a. Print ascending order\r\n" +
    "b. Print descending order\r\n" +
    "c. Input a fare and search in array and display\r\n" +
    "d. Print the max and min fares\r\n" +
    "e. Print duplicate elements");



Console.WriteLine("\nEnter the flight fare details of 5 flights\r");
int n = 5;
decimal[] fares = new decimal[n];

for (int i = 0; i < n; i++)
{
    Console.Write("\nFlight " + (i + 1) + " : ");
    fares[i] = Convert.ToDecimal(Console.ReadLine());
}

Console.WriteLine("\nAscending order : ");
for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        if (fares[i] > fares[j])
        {
            decimal temp = fares[i];
            fares[i] = fares[j];
            fares[j] = temp;
        }

    }
    Console.WriteLine(fares[i]);

}

Console.WriteLine("\nDescending order : ");

for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        if (fares[i] < fares[j])
        {
            decimal temp = fares[i];
            fares[i] = fares[j];
            fares[j] = temp;
        }

    }
    Console.WriteLine(fares[i]);

}


Console.WriteLine("\nEnter the fare to be searched : ");
decimal search_fare = Convert.ToDecimal(Console.ReadLine());
for (int i = 0; i < fares.Length; i++)
{
    if (fares[i] == search_fare)
    {
        Console.WriteLine("\nSearched fare is present in the list");
    }
    else
    {
        Console.WriteLine("\n Fare not found in the list");
        break;
    }
}




//...........Max and min values in an array............


for (int i = 0; i < fares.Length; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        if (fares[i] > fares[j])
        {
            decimal temp = fares[i];
            fares[i] = fares[j];
            fares[j] = temp;
        }

    }
}
//Console.WriteLine($"Maximum fare is {fares[fares.Length - 1]}");
Console.WriteLine("\nmin fare = " + fares[0]);
Console.WriteLine("\nmax fare = " + fares[(fares.Length) - 1]);




//............duplicate elements..................
Console.WriteLine("Duplicate elements: ");
for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        if (fares[i] == fares[j])
        {
            Console.WriteLine(fares[i]);

        }
    }
}