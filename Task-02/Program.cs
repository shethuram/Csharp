using System;

class Person
{
    // Private fields (actual storage)
    private string _name;
    private int _age;

    // Property for Name
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _name = value;
            }
            else
            {
                Console.WriteLine("Invalid name!");
            }
        }
    }

    // Property for Age
    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            if (value >= 0)
            {
                _age = value;
            }
            else
            {
                Console.WriteLine("Age cannot be negative!");
            }
        }
    }

    // Method
    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {_name} and I am {_age} years old.");
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person();
        p1.Name = "Ram";
        p1.Age = 20;

        Person p2 = new Person();
        p2.Name = "Kumar";
        p2.Age = -5;   // will trigger validation

        p1.Introduce();
        p2.Introduce();
    }
}