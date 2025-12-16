using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psil {

  public interface IReplIo {
    string ReadLine(string prompt);
    void WriteLine(string prompt);
    void Write(string text = "");
  }

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

  internal class PsilRepl {
    private readonly IReplIo _io;
    //private readonly Interpreter _interp; // MAL/Psil interpreter

    public PsilRepl(IReplIo io)//, Interpreter interp)
    {
        _io = io;
        //_interp = interp;
    }

    public void RunLoop()
    {
        while (true)
        {
            var line = _io.ReadLine("psil> ");
            if (line is null) break; // EOF / user closed

            if (string.IsNullOrWhiteSpace(line))
                continue;

            try
            {
                //var ast   = PsilParser.Parse(line);
                //var value = _interp.Eval(ast);
                //_io.WriteLine(Printer.Print(value));
            }
            catch (PsilException ex)
            {
                _io.WriteLine($"Error: {ex.Message}");
            }
        }
    }
  }
}
