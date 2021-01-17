using System;
using System.Collections.Generic;
using System.Text;

namespace ABSProject.Entities.Exceptions {
    class SizeException : ApplicationException{
        public SizeException(string message) : base(message) {
        }
    }
}
