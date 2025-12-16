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

  internal class Repl {
    private readonly IReplIo _io;
    private readonly Interpreter _interp; // MAL/Psil interpreter

    public Repl(IReplIo io, Interpreter interp)
    {
        _io = io;
        _interp = interp;
    }

    public void Run()
    {
        while (true)
        {
            var line = _io.ReadLine("psil> ");
            if (line is null) break; // EOF / user closed

            if (string.IsNullOrWhiteSpace(line))
                continue;

            try
            {
                string expr   = _interp.Read(line);
                string value = _interp.Eval(expr);
                _io.WriteLine(value);
            }
            catch (PsilException ex)
            {
                _io.WriteLine($"Error: {ex.Message}");
            }
        }
    }
  }
}
