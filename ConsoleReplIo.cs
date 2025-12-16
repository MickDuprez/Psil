using System;

namespace Psil {
  public sealed class ConsoleReplIo : IReplIo {
    public string ReadLine(string prompt) {
      Console.Write(prompt);
      return Console.ReadLine();
    }

    public void Write(string text) {
      Console.Write(text);
    }

    public void WriteLine(string text) {
      Console.WriteLine(text);
    }
  }
}
