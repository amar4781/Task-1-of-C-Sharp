// See https://aka.ms/new-console-template for more information
Console.WriteLine("Islam's Carpet Cleaning Service");
Console.WriteLine("Charges: ");
Console.WriteLine("    $25 for small carpet");
Console.WriteLine("    $35 for large carpet");
Console.WriteLine("Sales tax rate is 6%");
Console.WriteLine("Estimates are valid for 30 days");
Console.WriteLine("-----------------------------------------------" +
                  "-----------------------------------------------" +
                  "-----------------------------------------------" +
                  "-----------------------------------------------" +
             "----------------------------------------------------");
Console.WriteLine("Estimate for carpet cleaning service");
Console.Write("Enter number of small carpets: ");
int smallCarpets = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of large carpets: ");
int largeCarpets = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("-----------------------------------------------" +
                  "-----------------------------------------------" +
                  "-----------------------------------------------" +
                  "-----------------------------------------------" +
             "----------------------------------------------------");
int smallCarpetPrice = 25;
int largeCarpetPrice = 35;
double salesTaxRate = 0.06;
int cost = (smallCarpets * smallCarpetPrice) + (largeCarpets * largeCarpetPrice);
double tax = cost * salesTaxRate;
double totalEstimate = cost + tax;
Console.WriteLine($"Number of small carpets: {smallCarpets}");
Console.WriteLine($"Number of large carpets: {largeCarpets}");
Console.WriteLine($"Price of small carpet: ${smallCarpets * smallCarpetPrice}");
Console.WriteLine($"Price of large carpet: ${largeCarpets * largeCarpetPrice}");
Console.WriteLine($"Cost: ${cost}");
Console.WriteLine($"Tax: ${tax}");
Console.WriteLine($"Total estimate: ${totalEstimate}");
Console.WriteLine("This estimate is valid for 30 days");
