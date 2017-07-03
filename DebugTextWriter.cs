using System.Text;
using System;

namespace RedFlag.PersistenceEngine
{
    public class DebugTextWriter : System.IO.TextWriter
    {
        public override void Write(char[] buffer, int index, int count)
        {
            System.Diagnostics.Debug.Write(new String(buffer, index, count));
        }

        public override void Write(string value)
        {
            System.Diagnostics.Debug.Write(value);
        }

        public override Encoding Encoding
        {
            get { return System.Text.Encoding.Default; }
        }
    }
}

//taken from https://damieng.com/blog/2008/07/30/linq-to-sql-log-to-debug-window-file-memory-or-multiple-writers
//just so I don't lose it
