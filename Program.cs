// See https://aka.ms/new-console-template for more information
// In c# 10 we don't have to add main method, we can directly perform program



Console.WriteLine("Enter First Number : ");
float num1 = float.Parse(Console.ReadLine());
Console.WriteLine("Enter Second Number : ");
float num2 = float.Parse(Console.ReadLine());

float sum = num1 + num2;
float sub = num1 - num2;
float multi = num1 * num2;
float div = num1 / num2;

Console.WriteLine($"{num1} + {num2} = {sum}");
Console.WriteLine($"{num1} + {num2} = {sub}");
Console.WriteLine($"{num1} + {num2} = {multi}");
Console.WriteLine($"{num1} + {num2} = {div}");

Console.WriteLine("Hello, World!");

User user = new User();
user.Id = 10;
user.Name = "Mahir";
Console.WriteLine($"Id: { user.Id}, Name:{ user.Name}");

//Lambda expression improvements
var parse = (string str) => int.Parse(str);
Console.WriteLine(parse("18"));