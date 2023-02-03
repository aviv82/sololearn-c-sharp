// See https://aka.ms/new-console-template for more information


//lesson 24.1

myFunc();

static void myFunc()
{
    Console.WriteLine("This method prints a short message and returns no values");
}


//lesson 25.1

static void paraMethod(int x)
{
    if (x < 50)
    {
        Console.WriteLine("tails");
    } else if (x<1 || x>100)
    {
        Console.WriteLine("go fish");
    } else
    {
        Console.WriteLine("heads");
    }
}

    Console.WriteLine("give me a number between 0 and a 100");
    int yourNumber = Convert.ToInt32(Console.ReadLine());

paraMethod(yourNumber);


//lesson 26.1

static int rectArea(int a, int b)
{
    return a * b * 2;
}

Console.WriteLine("what is the length of your rectangle");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("what is the width of your rectangle");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("your rectangle's area is {0}", rectArea(width, length)); 


//lesson 27.1

static int expo(int num, int pow=2)
{
    int exponent = num;

    for (int x = 1; x < pow; x++)
    {
        exponent = exponent * num;
    }
    return exponent;
}

Console.WriteLine("what is the number we want to exponent?");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("how many times will the number be multiplied by itself");
int iteration = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("your number; {0}, multiplied by power of {1} is equal {2}", number, iteration, expo(num: number, pow: iteration));

