using System.Reflection.Metadata.Ecma335;

namespace Task3;

 abstract class Animal
{


   public string Name { get; set; }
      public Animal(string name)
   {
   Name = name;
   }

     public abstract string GetName();

     public abstract void Eat();

}
