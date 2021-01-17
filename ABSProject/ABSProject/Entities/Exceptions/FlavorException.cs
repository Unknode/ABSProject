using System;
using System.Collections.Generic;
using System.Text;

namespace ABSProject.Entities.Exceptions {
    class FlavorException : ApplicationException {
        public FlavorException(string message) : base(message) {
        }
    }
}
