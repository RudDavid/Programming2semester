using System;

class Person {
  public string Name;

  // Метод Clone создает копию текущего объекта
  public Person Clone() {
    return (Person)this.MemberwiseClone();
  }
}

class Program {
  static void Main(string[] args) {
    // Создаем первый объект
    Person p1 = new Person();
    p1.Name = "Ivan";

    // Создаем копию объекта
    Person p2 = p1.Clone();

    p2.Name = "Alex";

    Console.WriteLine("Первый объект: " + p1.Name);
    Console.WriteLine("Второй объект: " + p2.Name);
  }
}