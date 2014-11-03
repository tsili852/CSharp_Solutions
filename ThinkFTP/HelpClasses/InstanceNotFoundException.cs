using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkFTP.HelpClasses
{
    [Serializable]
    public class InstanceNotFoundException : Exception
    {
        public InstanceNotFoundException() { }
        public InstanceNotFoundException(string message) : base(message) { }
        public InstanceNotFoundException(string message, Exception inner) : base(message, inner) { }
        protected InstanceNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
