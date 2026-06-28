using System;

namespace SingletonPattern {
  public class Singleton {
    public static Singleton s_Instance {
      get {
        if (instance == null) instance = new Singleton();
        return instance;
      }
    }
    public void Method1() { 
      Console.WriteLine("Singleton.Method1"); 
    }
    public void Method2() { 
      Console.WriteLine("Singleton.Method2"); 
    }
    private Singleton() { 
    }
    private static Singleton instance;
  }
  class Program {
    static void Main(string[] args) {
      Singleton.s_Instance.Method1();
      Singleton.s_Instance.Method2();
    }
  }
}