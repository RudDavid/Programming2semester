using System;
using System.Collections.Generic;

namespace Iterator {
  class Program {
    static void Main(string[] args) {
      // Создаем коллекцию студентов
      List<string> students = new List<string>();

      // Добавляем элементы в коллекцию
      students.Add("Ivan");
      students.Add("Alex");
      students.Add("Maria");

      // Последовательно перебираем элементы коллекции
      foreach (string student in students) {
        Console.WriteLine(student);
      }
    }
  }
}