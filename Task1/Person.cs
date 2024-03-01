namespace Task1;

public class Person
{

public string Name { get; set; }

public Person(string name)
{

   Name = name;

}


public void ToString()
{

System.Console.WriteLine($"The {Name} is studying");

}

  

}
