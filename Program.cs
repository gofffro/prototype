using System;

namespace prototype
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Person original = new Person("Иван", 30);
      Person clone = (Person)original.Clone();

      clone.Name = "Степан";

      Console.WriteLine("Оригинал: " + original.Name + ", возраст: " + original.Age);
      Console.WriteLine("Клон: " + clone.Name + ", возраст: " + clone.Age);
    }
  }

  public class Person : ICloneable
  {
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
      Name = name;
      Age = age;
    }

    public object Clone()
    {
      return this.MemberwiseClone();
    }
  }
}
