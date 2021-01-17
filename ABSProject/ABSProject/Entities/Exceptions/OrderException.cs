using System;
using System.Collections.Generic;
using System.Text;

namespace ABSProject.Entities.Exceptions {
    class OrderException:ApplicationException {

        public OrderException(string message) : base(message) {

        }
    }
}
