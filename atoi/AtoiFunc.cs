using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atoi
{
    public class AtoiFunc
    {
        public int Parse(string _number)
        {
            int AsInteger = 0;
            bool symbol = GetSymbol(_number);
            for (int i = 0; i < _number.Length; i++)
            {
                if (AsInteger != 0 && !IsNumber(_number[i]) && _number[i] != '.')
                    throw new FormatException();
                else if (IsNumber(_number[i]))
                {
                    if ((AsInteger *= 10) < 0)
                        throw new ArithmeticException();
                    else
                        AsInteger = AsInteger + GetIntForChar(_number[i]);
                }
                else if (AsInteger != 0)
                    return PositiveNegative(symbol, AsInteger);
            }
            return PositiveNegative(symbol, AsInteger);
        }
        public bool IsSymbol(char item)
        {
            if (item == '-')
                return true;
            else if (item == '+')
                return true;
            return false;
        }
        public bool IsNumber(char item)
        {
            int n = item;
            return n >= 48 && n <= 57;
        }
        public bool GetSymbol(string givenString)
        {
            foreach(char ccc in givenString)
            {
                if (ccc == '-')
                    return false;
                else if ((int)ccc >= 48 && (int)ccc <= 57)
                    return true;
            }
            return true;
        }
        public int PositiveNegative(bool _item, int result)
        {
            if(!_item)
                return result * -1;
            return result;
        }
        public int GetIntForChar(char _char)
        {
            return _char - 48;
        }
        public AtoiFunc()
        {
            
        }
    }
}
