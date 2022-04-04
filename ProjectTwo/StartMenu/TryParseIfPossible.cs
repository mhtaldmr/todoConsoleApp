using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    public static class TryParseIfPossible
    {
        public static byte FromStringToByte(string stringToConvert)
        {
            if (Byte.TryParse(stringToConvert, out byte byteValue))
                return byteValue;
            else
                return 0;
        }
    }
}
