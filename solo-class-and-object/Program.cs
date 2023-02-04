// See https://aka.ms/new-console-template for more information


// lesson 37.1


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


