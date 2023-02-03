// See https://aka.ms/new-console-template for more information


//lesson 24.1

MyFunc();

static void MyFunc()
{
    Console.WriteLine("This method prints a short message and returns no values");
}


//lesson 25.1

static void ParaMethod(int x)
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

ParaMethod(yourNumber);


//lesson 26.1

static int RectArea(int a, int b)
{
    return a * b * 2;
}

Console.WriteLine("what is the length of your rectangle");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("what is the width of your rectangle");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("your rectangle's area is {0}", RectArea(width, length)); 


//lesson 27.1

static int Expo(int num, int pow=2)
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

Console.WriteLine("your number; {0}, multiplied by power of {1} is equal {2}", number, iteration, Expo(num: number, pow: iteration));


//lesson 28.1

static void Define( ref int ordinal, out int lottery)
{
    Random rnd = new Random();
    ordinal = ordinal + 1;
    lottery = rnd.Next(0, 100);
}

int a;
int b = 2;

Console.WriteLine("original values a: undefined and b: {0}", b);

Define(ref b, out a);

Console.WriteLine("new values a: {0} and b: {1}", a, b);


// lesson 29.1

//this unfortunately doesn't work.. :/

/*
static void Print(int a)
{
    Console.WriteLine(a);
}

static void Print(double a)
{
    Console.WriteLine(a);
}

static void Print(string a)
{
    Console.WriteLine(a);
}

Print(5);
Print(5.5);
Print("five point five");
*/


// lesson 30.1

Console.WriteLine("what is the number we want to factor?");
int factor = Convert.ToInt32(Console.ReadLine());

static int Fact(int factor)
{
    if (factor == 1)
    {
        return 1;
    }
    return factor * Fact(factor - 1);
}

Console.WriteLine("the factor of your number("+ factor +") is; " + Fact(factor));

