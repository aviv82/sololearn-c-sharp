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

//lesson 15.1

Console.WriteLine("how far do you want to count down?");
int countDown = Convert.ToInt32(Console.ReadLine());

while (countDown-- > 0)
{
    Console.WriteLine(countDown);
}


//lesson 16.1

Console.WriteLine("how far do you want to count up?");
int countUp = Convert.ToInt32(Console.ReadLine());


for (int x = 1; x <= countUp; x++)
{
    Console.WriteLine(x);
}


//lesson 17.1

int o = 0;
    do
    {
        Console.WriteLine(o);
        o++;
        Console.WriteLine("oy!");
    } while (o <= countUp);


//lesson 18.1

for (int p = 0; p < 200; p++)
{
    if (p%2==0)
    {
        Console.WriteLine("duck!");
    }

    if (p % 4 == 0)
    {
        continue;
    }

    if (p % 98 == 0)
    {
        Console.WriteLine("goose!");
        break;
    }
}


//lesson 19.1

Console.WriteLine("how many legs does your artropod have?");
int legs = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("how many body parts does your artropod have?");
int bodyParts = Convert.ToInt32(Console.ReadLine());

if (legs >= 6 || bodyParts < 3)
{
    Console.WriteLine("arachnide");
}
else if (legs == 6 && bodyParts == 3)
{
    Console.WriteLine("insect");
}
else Console.WriteLine("alien");


//lesson 20.1

Console.WriteLine("guess my age");
int age = Convert.ToInt32(Console.ReadLine());

bool right = (age == 40) ? true : false;

if (right) {
    Console.WriteLine("ping pong");
} else {
    Console.WriteLine("nope");
}

Console.ReadLine();