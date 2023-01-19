// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nEnter your Date of birth(YYYY-MM-DD): ");
DateTime birthday = Convert.ToDateTime(Console.ReadLine());


TimeSpan age = DateTime.Now - birthday;

double hours = age.TotalHours;
Console.WriteLine("\nHours you lived : "+ Convert.ToInt32(hours));

double days = age.TotalDays;
Console.WriteLine("\n Days you lived : " + Convert.ToInt32(days));
 
double weeks = days / 7; 
Console.WriteLine("\n Weeks you lived : " + Convert.ToInt32(weeks));

double months = days / 31;
Console.WriteLine("\n Months you lived : " + Convert.ToInt32(months));

double years = days / 365;
Console.WriteLine("\n Years you lived : " + Convert.ToInt32(years));

int year = birthday.Year;

if(year % 4 == 0)
{
    Console.WriteLine("\nyou are born in a leap year");
}
else
{
    Console.WriteLine("\nyou are not born in a leap year");
}