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