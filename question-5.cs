// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata.Ecma335;


Console.WriteLine("Enter the no. of fare details to be entered : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n Enter the fares : ");
decimal[] fares = new decimal[n];
for(int i = 0; i < n;i++)
{
    fares[i] = Convert.ToDecimal(Console.ReadLine());
}
int odd = 1;
int even = 0;

decimal[] new_fare = new decimal[10];
for(int i = 0;i < n;i++)
{
    if (fares[i] % 2 == 0)
    {
        new_fare[even] = fares[i];
        even = even + 2;
    }
    else
    {
        new_fare[odd] = fares[i];
        odd = odd + 2;
    }
}
Console.WriteLine("Following are the fare in odd and even position");
foreach (var item in new_fare)
{
    Console.WriteLine("\n"+item);
}