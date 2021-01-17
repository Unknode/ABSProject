using System;
using System.Collections.Generic;
using System.Text;

namespace ABSProject.Entities.Exceptions {
    class DeliveryException:ApplicationException {

        public DeliveryException (string message) : base (message) {
        }

    }
}
