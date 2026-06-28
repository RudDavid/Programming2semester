using System;

namespace Builder {
  class Car {
    public string Engine;
    public string Color;
  }

  class CarBuilder {
    private Car car = new Car();

    // Устанавливаем двигатель
    public void SetEngine(string engine) {
      car.Engine = engine;
    }

    // Устанавливаем цвет
    public void SetColor(string color) {
      car.Color = color;
    }

    // Возвращаем готовый автомобиль
    public Car Build() {
      return car;
    }
  }

  class Program {
    static void Main(string[] args) {
      // Создаем строителя
      CarBuilder builder = new CarBuilder();

      // Поэтапно собираем автомобиль
      builder.SetEngine("V8");
      builder.SetColor("Black");

      // Получаем готовый объект
      Car car = builder.Build();

      Console.WriteLine("Двигатель: " + car.Engine);
      Console.WriteLine("Цвет: " + car.Color);
    }
  }
}