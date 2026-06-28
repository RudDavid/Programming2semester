using System;

namespace FactoryMethod {
  interface ITransport {
    void Drive();
  }

  class Car : ITransport {
    public void Drive() {
      Console.WriteLine("Едет автомобиль");
    }
  }

  class Bike : ITransport {
    public void Drive() {
      Console.WriteLine("Едет велосипед");
    }
  }

  // Фабрика
  class TransportFactory {
    public ITransport Create(string type) {
      if (type == "Car")
        return new Car();

      return new Bike();
    }
  }

  class Program {
    static void Main(string[] args) {
      TransportFactory factory = new TransportFactory();

      ITransport transport = factory.Create("Car");

      transport.Drive();
    }
  }
}