using System;

namespace mvc {
  class Model {
    public string Text = "Hello";
  }

  class View {
    public void Show(string text) {
      Console.WriteLine(text);
    }
  }

  class Controller {
    private Model model = new Model();
    private View view = new View();

    public void Display() {
      view.Show(model.Text);
    }
  }

  class Program {
    static void Main(string[] args) {
      Controller controller = new Controller();

      controller.Display();
    }
  }
}