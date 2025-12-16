using System;
using System.Runtime.Serialization;

namespace Psil {
  [Serializable]
  internal class PsilException : Exception {
    public PsilException() {
    }

    public PsilException(string message) : base(message) {
    }

    public PsilException(string message, Exception innerException) : base(message, innerException) {
    }

    protected PsilException(SerializationInfo info, StreamingContext context) : base(info, context) {
    }
  }
}