using System.Globalization;

double pi, radius, radSquar, area;

pi = 3.14159;
radius = double.Parse(Console.ReadLine(),CultureInfo.CreateSpecificCulture("en-US"));
radSquar = Math.Pow(radius,2);
area = radSquar * pi;

Console.WriteLine("A = " + area.ToString("F4",CultureInfo.CreateSpecificCulture("en-US")));
Console.Read();