using System;

namespace Memento {
  class Memento {
    // Поле хранит сохраненное состояние
    public string State;

    // Конструктор сохраняет состояние
    public Memento(string state) {
      State = state;
    }
  }

  class Editor {
    // Текущее состояние редактора
    public string Text;

    // Метод сохраняет состояние
    public Memento Save() {
      return new Memento(Text);
    }

    // Метод восстанавливает состояние
    public void Restore(Memento memento) {
      Text = memento.State;
    }
  }

  class Program {
    static void Main(string[] args) {
      Editor editor = new Editor();

      // Первая версия текста
      editor.Text = "Первая версия";

      // Сохраняем состояние
      Memento save = editor.Save();

      // Изменяем текст
      editor.Text = "Вторая версия";

      Console.WriteLine(editor.Text);

      // Восстанавливаем сохранение
      editor.Restore(save);

      Console.WriteLine(editor.Text);
    }
  }
}