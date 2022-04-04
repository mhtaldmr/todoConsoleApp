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
            byte byteValue;
            bool result = Byte.TryParse(stringToConvert, out byteValue);
            if (result)
                return byteValue;
            else
                return 0;
        }
    }
}
