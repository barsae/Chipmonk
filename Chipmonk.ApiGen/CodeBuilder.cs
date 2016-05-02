using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipmonk.ApiGen {
    public class CodeBuilder {
        public StringBuilder Code { get; private set; }
        public int IndentCount;

        private bool startOfLine = true;

        public string Indentation {
            get {
                return new string(' ', IndentCount * 4);
            }
        }

        public CodeBuilder() {
            Code = new StringBuilder();
            IndentCount = 0;
        }

        public void AppendLine() {
            Code.AppendLine();
            startOfLine = true;
        }

        public void Append(string format, params object[] args) {
            CheckIfIndentationNeedsAppended();
            Code.Append(string.Format(format, args));
        }

        public void AddLine(string format, params object[] args) {
            CheckIfIndentationNeedsAppended();
            Code.AppendLine(string.Format(format, args));
            startOfLine = true;
        }

        public void Indent() {
            IndentCount++;
        }

        public void Dedent() {
            IndentCount--;
        }

        public override string ToString() {
            return Code.ToString();
        }

        private void CheckIfIndentationNeedsAppended() {
            if (startOfLine) {
                Code.Append(Indentation);
                startOfLine = false;
            }
        }
    }
}
