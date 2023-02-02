// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// lesson 13.1

Console.WriteLine("please input picture height");
int height = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("please input picture width");
int width = Convert.ToInt32(Console.ReadLine());

if (height > width)
{
    Console.WriteLine("portrait"); }
    else if (height == width)
    {
    Console.WriteLine("square");
    }   
    else
    {
    Console.WriteLine("landscape");
    }

Console.ReadLine();