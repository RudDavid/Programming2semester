using System;


interface IPayment {
  void Pay();
}

class CardPayment : IPayment {
  public void Pay() {
    Console.WriteLine("Оплата картой");
  }
}

class CashPayment : IPayment {
  public void Pay() {
    Console.WriteLine("Оплата наличными");
  }
}

class Shop {
  private IPayment payment;

  // Конструктор получает способ оплаты
  public Shop(IPayment _payment) {
    payment = _payment;
  }

  // Покупка
  public void Buy() {
    payment.Pay();
  }
}

class Program {
  static void Main(string[] args) {
    Shop shop1 = new Shop(new CardPayment());
    shop1.Buy();

    Shop shop2 = new Shop(new CashPayment());
    shop2.Buy();
  }
}