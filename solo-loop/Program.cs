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

// lesson 14.1

Console.WriteLine("how many angles does your polygon have");
int angles = Convert.ToInt32(Console.ReadLine());


switch (angles)
{
    case 3:
        Console.WriteLine("triangle");
        break;
    case 4:
        Console.WriteLine("rectangle");
        break;
    case 5:
        Console.WriteLine("pentagon");
        break;
    case 6:
        Console.WriteLine("hectagon");
        break;
    case 7:
        Console.WriteLine("septagon");
        break;
    case 8:
        Console.WriteLine("hexagon");
        break;
    default:
        Console.WriteLine("toomanyagon");
        break;
}



Console.ReadLine();