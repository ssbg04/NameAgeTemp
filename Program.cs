// See https://aka.ms/new-console-template for more information
Console.WriteLine("-----------------------------------BSIT1C_GROUP3-----------------------------------");
Console.Write("Enter your name: ");
string? name = Convert.ToString(Console.ReadLine());
Console.Write("Enter your age: "); 
double countAge = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter your temperature: ");
double temp = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");

Console.WriteLine("-----------------------------------");
if(temp >= 36 && temp <= 37.2)
{
    Console.WriteLine("Your temperature is Normal!");
}else if(temp >= 37.4 && temp <= 38.2)
{
    Console.WriteLine("Your temperature is Low Fever!");
}else if(temp >= 38.4 && temp <= 39.2)
{
    Console.WriteLine("Your temperature is Fever!");
}else if(temp <= 35.4)
{
    Console.WriteLine("Get some moves bvro!");
}else
{
    Console.WriteLine("Your temperature is High Fever!");
}
Console.WriteLine("-----------------------------------");

Console.WriteLine(" ");
Thread.Sleep(1000);
Console.WriteLine("Your name is: " + name);
Console.WriteLine("Your age is: " + countAge);
Console.WriteLine("Your temperature is: " + temp);
Console.WriteLine(" ");
Console.WriteLine($"Your name is {name} and you're {countAge} years old, your body temperature is {temp} degrees celcius.");

Console.WriteLine("Press 'Enter' key to exit...");
while(Console.ReadKey(true).Key != ConsoleKey.Enter){
    
}
