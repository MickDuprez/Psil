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
      var read = new Reader();
      var eval = new Evaluator();
      var io = new ConsoleReplIo();
      var printer = new PsilRepl(io);
      printer.RunLoop();
    }
  }
}
