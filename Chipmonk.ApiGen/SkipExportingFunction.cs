using System;
using System.Runtime.Serialization;

namespace Chipmonk.ApiGen {
    [Serializable]
    internal class SkipExportingFunction : Exception {
        public SkipExportingFunction() {
        }

        public SkipExportingFunction(string message) : base(message) {
        }

        public SkipExportingFunction(string message, Exception innerException) : base(message, innerException) {
        }

        protected SkipExportingFunction(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}