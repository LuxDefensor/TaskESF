using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskDataESF
{

    [Serializable]
    public class NotAllowedException : Exception
    {
        public NotAllowedException()
        {
        }
        public NotAllowedException(string message) : base(message) { }
        public NotAllowedException(string message, Exception inner) : base(message, inner) { }
        protected NotAllowedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
