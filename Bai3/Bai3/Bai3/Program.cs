

Console.WriteLine("input math score = ");
string mathScore = Console.ReadLine();
Console.WriteLine("input literature score = ");
string literatureScore = Console.ReadLine();

Console.WriteLine(mathScore);
Console.WriteLine(literatureScore);

//double mathS = double.Parse(mathScore);
//double litS = double.Parse(literatureScore);

bool check1 = double.TryParse(mathScore, out double mathS);
bool check2 = double.TryParse(literatureScore, out double litS);

double avgScore = (mathS + litS)/2;
Console.WriteLine("avg = " +  avgScore);

Console.WriteLine($"math score = {mathS} literature score = {litS} => avg score = {avgScore}");

Console.ReadKey();



