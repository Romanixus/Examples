int numA = new Random().Next(1, 100);
int numB = new Random().Next(1, 100);
int numC = new Random().Next(1, 100);

int max = numA;
if (numB > max) max = numB;
if (numC > max) max = numC;

Console.WriteLine(numA);
Console.WriteLine(numB);
Console.WriteLine(numC);
Console.Write(max);