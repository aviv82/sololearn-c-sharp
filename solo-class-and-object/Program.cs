// See https://aka.ms/new-console-template for more information


// see classes below

// lesson 36.1


Bread bagguette = new Bread();


bagguette.dough = "white";
bagguette.name = "bagguette";
bagguette.weight = 200;

bagguette.Print();

Bread brioche = new Bread();

brioche.dough = "butter";
brioche.name = "brioch";
brioche.weight = 300;

brioche.Print();


//lesson 37.1


Spy black = new Spy();

black.SetMatchWord("hush hush");
Console.WriteLine("the matchword is: {0}", black.GetMatchWord());


// classes

// lesson 36.1 class


class Bread
{
    public string dough;
    public string name;
    public int weight;

    public void Print()
    {
        Console.WriteLine("this bread is called {0}, it is made with {1} dough and weighs {2} grams", name, dough, weight);
    }
}


// lesson 37.1 class


class Spy
{
    private string matchWord;

    public void SetMatchWord(string s)
    {
        matchWord = s;
    }

    public string GetMatchWord()
    {
        return matchWord;
    }
}

