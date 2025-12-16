using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psil {
  public class Interpreter {
    private Reader read;
    private Evaluator eval;

    public Interpreter(Reader reader, Evaluator evaluator) {
      this.read = reader;
      this.eval = evaluator;
    }

    internal string Eval(string expr) {
      return expr;
    }

    internal string Read(string line) {
      return line;
    }
  }
}
