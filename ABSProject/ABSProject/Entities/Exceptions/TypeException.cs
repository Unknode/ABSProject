using System;
using System.Collections.Generic;
using System.Text;

namespace ABSProject.Entities.Exceptions {
    class TypeException : ApplicationException{
        public TypeException(string message) : base(message) {
        }
    }
}
