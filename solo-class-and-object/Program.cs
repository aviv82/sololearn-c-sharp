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


// lesson 38.1

Robot deathRay = new Robot("kill");


// lesson 39.1


Pass dummy = new Pass();

dummy.Password = "1234";
dummy.Email = "dumm@y.com";
dummy.Print();




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


//lesson 38.1 class

class Robot
{
    private string objective;

    public Robot(string o)
    {
        objective = o;
        Console.WriteLine(o);
    }
}


// lesson 39.1 class

class Pass
{
    private string email;
    public string Password {get; set;}
    public string Email {
        set
        {
            if (value.Length>6)
            
                email = value;
            
        } get { return email; }
    }
    
    public void Print()
    {
        Console.WriteLine("the password for email account {0} is; {1}", Email, Password);
    }
    
} 



