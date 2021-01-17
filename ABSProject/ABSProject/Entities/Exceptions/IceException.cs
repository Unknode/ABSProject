using System;
using System.Collections.Generic;
using System.Text;

namespace ABSProject.Entities.Exceptions {
    class IceException:ApplicationException {
        public IceException(string message) : base(message) {
        }
    }
}
