using System;
using System.Collections.Generic;
using System.Text;

namespace WordProcessor {
    public class InvalidStringException : Exception {
        public InvalidStringException(string message) : base(message) {
        }
    }
}
