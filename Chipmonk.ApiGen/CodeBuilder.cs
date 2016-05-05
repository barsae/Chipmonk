using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chipmonk.ApiGen.Models;

namespace Chipmonk.ApiGen {
    public class CodeBuilder {
        public StringBuilder Code { get; private set; }
        public int IndentCount;

        private bool startOfLine = true;
        private string separator = null;
        private bool startOfSeparatedList = false;

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
            HandleSeparator();

            var toAppend = string.Format(format, args);
            Code.Append(toAppend);

            if (toAppend.EndsWith(Environment.NewLine)) {
                startOfLine = true;
            }
        }

        public void AppendLine(string format, params object[] args) {
            Append(format + Environment.NewLine, args);
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

        public void StartSeparatedList(string separator) {
            this.separator = separator;
            startOfSeparatedList = true;
        }

        public void EndSeparatedList() {
            separator = null;
        }

        private void CheckIfIndentationNeedsAppended() {
            if (startOfLine) {
                Code.Append(Indentation);
                startOfLine = false;
            }
        }

        private void HandleSeparator() {
            if (separator != null && !startOfSeparatedList) {
                Code.Append(separator);
            }

            startOfSeparatedList = false;
        }
    }
}
