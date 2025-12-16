using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psil {
  internal class Program {
    static void Main(string[] args) {
      // create a Repl  (Printer, the Reader and the Evaluator)
      var io = new ConsoleReplIo();
      var reader = new Reader();
      var evaluator = new Evaluator();
      var interp = new Interpreter(reader, evaluator);
      var repl = new Repl(io, interp);
      repl.Run();
    }
  }
}
