class Dog
{
    string _Name;
    // Below are getters and setters in C#
    public string Name
    {
        get
        {
            return _Name;
        }
        set
        {
            _Name = value;
        }
    }
    string _Breed;
    public string Breed
    {
        get
        {
            return _Breed;
        }
        set
        {
            _Breed = value;
        }
    }
    int _Weight;
    public int Weight
    {
        get
        {
            return _Weight;
        }
        set
        {
            _Weight = value;
        }
    }

    public Dog(string Name, string Breed, int Weight)
    {
        this.Name = Name;
        this.Breed = Breed;
        this.Weight = Weight;
    }

    public void Bark()
    {
        Console.WriteLine("Woof!");
    }

}