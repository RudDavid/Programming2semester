using System;


// Базовый обработчик
abstract class Handler {
  protected Handler next;

  // Устанавливаем следующего обработчика
  public void SetNext(Handler handler) {
    next = handler;
  }

  // Метод обработки запроса
  public abstract void Handle(string request);
}

class Manager : Handler {
  public override void Handle(string request) {
    if (request == "Отпуск") {
      Console.WriteLine("Менеджер обработал заявку");
    } else if (next != null) {
      next.Handle(request);
    }
  }
}

class Director : Handler {
  public override void Handle(string request) {
    Console.WriteLine("Директор обработал заявку");
  }
}

class Program {
  static void Main(string[] args) {
    Manager manager = new Manager();
    Director director = new Director();

    // Соединяем их в цепочку
    manager.SetNext(director);

    manager.Handle("Отпуск");
  }
}