namespace Task3;

 class Dog :Animal
{


   public Dog(string name):base(name)
   {

   }

    public override void Eat()
    {
        System.Console.WriteLine($"Eating");
    }

    public override string GetName()
    {
        return Name;
    }
}
