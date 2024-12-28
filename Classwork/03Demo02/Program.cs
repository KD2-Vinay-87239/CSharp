using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IX obj = new Maths();
            //Maths maths = (Maths)obj;      //upcasting 

        }


        public interface IX
        {
            int Add(int x, int y);
            int Sub(int x, int y);
        }

        public interface IY
        {
            int Mul(int x, int y);
            int Div(int x, int y);
        }

        public class Maths : IX, IY
        {
            public int Add(int x, int y)
            {
                return x + y;
            }

            public int Sub(int x, int y)
            {
                return x - y;
            }

            public int Mul(int x, int y)
            {
                return x * y;
            }

            public int Div(int x, int y)
            {
                return x / y;
            }
        }
    }
}
