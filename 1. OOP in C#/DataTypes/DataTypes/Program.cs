using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            object variable;

            int i;
            i = 30;
            i = 212;                 /* Legal */
            i = 0213;                /* octal */
            i = 0x4b;                /* hexadecimal */
            variable = int.MinValue;
            variable = int.MaxValue;
            variable = default(int);
            size = sizeof(int);

            uint u;
            u = 30;
            u = 215U;                /* Legal */
            u = 30u;                 /* unsigned int */
            variable = uint.MinValue;
            variable = uint.MaxValue;
            variable = default(uint);
            size = sizeof(uint);

            long l;
            l = 30;
            l = 0xFeeL;              /* Legal */
            l = 30L;                 /* long */
            variable = long.MinValue;
            variable = long.MaxValue;
            variable = default(long);
            size = sizeof(long);

            ulong ul;
            ul = 30;
            ul = 30ul;                /* unsigned long */
            variable = ulong.MinValue;
            variable = ulong.MaxValue;
            variable = default(ulong);
            size = sizeof(ulong);

            decimal m;
            m = 3.3M;
            m = 85M;                 /* decimal */
            m = 2E-3m;
            variable = decimal.MinValue;
            variable = decimal.MaxValue;
            variable = default(decimal);
            size = sizeof(decimal);

            float f;
            f = 3.3F;
            f = 3.14159F;            /* Legal */
            f = 2E-3f;
            variable = float.MinValue;
            variable = float.MaxValue;
            variable = default(float);
            size = sizeof(float);

            double d;
            d = 3.3;
            d = 3.14159D;            /* Legal */
            d = 314159E-5;           /* Legal */
            variable = double.MinValue;
            variable = double.MaxValue;
            variable = default(double);
            size = sizeof(double);

            char c;
            c = 'a';
            c = 'A';
            c = '^';
            c = '\'';                // Escape: single quote
            c = '\\';                // Escape: backslash
            c = '\x45';              // Hex code for ASCII 'E'
            c = '\x20AC';            // Hex code for Euro sign
            c = '€';                 // Euro sign directly in code
            variable = char.MinValue;
            variable = char.MaxValue;
            variable = default(char);
            size = sizeof(char);

            string s = "ABC";
            variable = "c:\\path\\to";
            variable = @"c:\path\to";
            variable = @"Line1\n Line2";
            variable = @"Line1, \
Line2";
            variable = @"sample is ""sample"" here";
            variable = default(string);























            Console.ReadKey();
        }
    }
}
