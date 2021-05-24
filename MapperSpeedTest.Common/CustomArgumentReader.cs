using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapperSpeedTest.Common
{
    public class CustomArgumentReader
    {
        private readonly string[] _args;

        public CustomArgumentReader(string[] args)
        {
            _args = args;
        }

        public int GetCount()
        {
            var idx = Array.IndexOf(_args, "-c");
            if (idx < 0 || _args.Length == idx)
            {
                return 1;
            }

            string strCount = _args[idx + 1];

            if(!int.TryParse(strCount, out int intCount))
            {
                intCount = 1;
            }

            return intCount;
        }

        public bool GetExplicit()
        {
            return _args.Contains("-e");
        }
    }
}
