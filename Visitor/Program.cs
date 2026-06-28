using System;

namespace Visitor {

  // Интерфейс посетителя
  interface IVisitor {
    void Visit(Book book);
  }

  class Book {
    public string Title = "C#";

    // Передаем книгу посетителю
    public void Accept(IVisitor visitor) {
      visitor.Visit(this);
    }
  }

  // Посетитель
  class PrintVisitor : IVisitor {
    public void Visit(Book book) {
      Console.WriteLine(book.Title);
    }
  }

  class Program {
    static void Main(string[] args) {
      Book book = new Book();

      PrintVisitor visitor = new PrintVisitor();

      book.Accept(visitor);
    }
  }
}